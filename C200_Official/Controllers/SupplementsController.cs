using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C200_Official.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Rotativa.AspNetCore;

namespace C200_Official.Controllers
{
    public class SupplementsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SupplementsController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _env = environment;
        }

        // GET: Supplements
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Supplements.Include(s => s.Member).Include(s => s.SupplementType);
            return View(await appDbContext.ToListAsync());
        }

        public async Task<IActionResult> IndexMember() // an area for user to see the supplements they posted 
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Supplements
                                .Where(a => a.MemberId == userId)
                               .Include(a => a.SupplementType)
                               .Include(a => a.Member);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Supplements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplement = await _context.Supplements
                .Include(s => s.Member)
                .Include(s => s.SupplementType)
                .Where(q => q.Status.Equals("Published"))
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplement == null)
            {
                return NotFound();
            }

            return View(supplement);
        }

        public async Task<IActionResult> IndexMemberDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var video = await _context.Supplements
                .Where(m => m.Id == id)
                .Include(v => v.SupplementType)
                .Include(v => v.Member)
                .FirstOrDefaultAsync();
            if (video == null)
            {
                return NotFound();
            }

            return View(video);
        }

        public async Task<IActionResult> IndexSupplementAdmin(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supp = await _context.Supplements
                //for a supplement in the supplements table i want to get the supplement type record
                .Where(m => m.Id == id)
                .Include(a => a.SupplementType)
                .Include(a => a.Member)
                .FirstOrDefaultAsync();

            if (supp == null)
            {
                return NotFound();
            }
            return View(supp);
        }

        // GET: Supplements/Create
        public IActionResult Create()
        {
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username");
            ViewData["SupplementId"] = new SelectList(_context.SupplementTypes, "Id", "Name");
            return View();
        }

        // POST: Supplements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Picture,Description,SuggestedUse,Warnings," +
            "SupplementTypeId,MemberId,Status")] Supplement supplement, IFormFile image)
        {
            if (ModelState.IsValid)
            {

                // Upload photo
                string fname = DoPhotoUpload(image);

                supplement.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                supplement.Picture = fname;
                _context.Add(supplement);
                await _context.SaveChangesAsync();
                TempData["Message"] = "New Supplement Information sucessfully created.";
                TempData["MsgType"] = "success";
                return RedirectToAction("ApprovalOfSupplements");
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", supplement.MemberId);
            ViewData["SupplementTypeId"] = new SelectList(_context.SupplementTypes, "Id", "Name", supplement.SupplementType);
            return View(supplement);
        }


        // GET: Supplements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplement = await _context.Supplements.FindAsync(id);
            if (supplement == null)
            {
                return NotFound();
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", supplement.MemberId);
            ViewData["SupplementId"] = new SelectList(_context.SupplementTypes, "Id", "Name", supplement.SupplementType);
            return View(supplement);
        }

        // POST: Supplements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Picture,Description,SuggestedUse,Warnings,SupplementTypeId,MemberId,Status")] Supplement supplement, IFormFile image)
        {
            if (id != supplement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                IFormCollection form = HttpContext.Request.Form;
                string tickpic = form["chkpic"].ToString().Trim();
                string fname = DoPhotoUpload(image);
                supplement.MemberId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                supplement.Picture = fname;

                try
                {
                    _context.Update(supplement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplementExists(supplement.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MemberId"] = new SelectList(_context.Members, "Id", "Username", supplement.MemberId);
            ViewData["SupplementTypeId"] = new SelectList(_context.SupplementTypes, "Id", "Name", supplement.SupplementType);
            return View(supplement);
        }

        public IActionResult Delete(int id)
        {
            DbSet<Supplement> dbs = _context.Supplements;

            Supplement supp = dbs.Where(so => so.Id == id).FirstOrDefault();

            if (supp != null)
            {
                var suppType = _context.Supplements.Include(x => x.SupplementType).First(x => x.Id == id);
                _context.Supplements.Remove(suppType);
                _context.SaveChanges();
                TempData["Msg"] = "Supplement post being deleted successfully.";
                TempData["MsgType"] = "success";
                return RedirectToAction("ApprovalOfSupplements");
            }
            else
            {
                TempData["Msg"] = "Supplement ID not found!";
                TempData["MsgType"] = "danger";
                return RedirectToAction("ApprovalOfSupplements");
            }
        }


        private bool SupplementExists(int id)
        {
            return _context.Supplements.Any(e => e.Id == id);
        }

        //USER ARCHIVE
        public IActionResult ArchiveSupplement(int id)
        {

            DbSet<Supplement> dbs = _context.Supplements;
            Supplement supp = dbs.Where(so => so.Id == id).FirstOrDefault();
            if (supp != null)
            {
                supp.Status = "ArchivedByUser";
                if (_context.SaveChanges() == 1)
                {
                    TempData["Msg"] = "Supplement Post Archived!";
                    TempData["MsgType"] = "success";
                }
                else
                {
                    TempData["Msg"] = "Failed to archived!";
                    TempData["MsgType"] = "danger";
                }
            }
            else
            {
                TempData["Msg"] = "Article ID not found!";
                TempData["MsgType"] = "danger";
            }
            return RedirectToAction("IndexMember");
        }

        //USER UNARCHIVE 
        public IActionResult UnarchiveSupplement(int id)
        {

            DbSet<Supplement> dbs = _context.Supplements;
            Supplement supp = dbs.Where(so => so.Id == id).FirstOrDefault();
            UpdateStatusToPublish(supp);
            return RedirectToAction("IndexMember");
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApprovalOfSupplements()
        {
            //who is currently login in as the current user, to let her see her own supplement post
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var appDbContext = _context.Supplements
                                .Where(a => a.Status.Equals("Pending"))
                               .Include(a => a.SupplementType)
                               .Include(a => a.Member);
            return View(await appDbContext.ToListAsync());
        }

        //ACTION approve
        [Authorize(Roles = "Admin")]
        public IActionResult ApproveSupplements(int id)
        {

            DbSet<Supplement> dbs = _context.Supplements;
            Supplement supp = dbs.Where(so => so.Id == id).FirstOrDefault();
            UpdateStatusToPublish(supp);
            TempData["Message"] = "Supplement Info being approved.";
            TempData["MsgType"] = "success";
            return RedirectToAction("ApprovalOfSupplements");
        }

        public void UpdateStatusToPublish(Supplement supplements)
        {
            string orginalStatus = supplements.Status;
            if (supplements != null)
            {
                supplements.Status = "Published";
                if (_context.SaveChanges() == 1)
                    if (orginalStatus.Equals("Pending"))
                    {
                        TempData["Msg"] = "Supplement published successfully.";
                        TempData["MsgType"] = "success";
                    }
                    else
                    {
                        TempData["Msg"] = "Supplement being unarchived.";
                        TempData["MsgType"] = "success";
                    }
                else
                    TempData["Msg"] = "Failed to unarchived supplement!";
                TempData["MsgType"] = "danger";
            }
            else
            {
                TempData["Msg"] = "Supplement ID not found!";
                TempData["MsgType"] = "danger";
            }

        }

        public IActionResult PrintListOfSupplements()
        {
            DbSet<Supplement> dbs = _context.Supplements;
            var model = dbs.Include(a => a.Member)
                           .ToList();

            if (model != null)
                return new ViewAsPdf(model)
                {
                    PageSize = Rotativa.AspNetCore.Options.Size.B5,
                    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape
                };
            else
            {
                TempData["Msg"] = "Error occured";
                return RedirectToAction("Index");
            }

        }

        private string DoPhotoUpload(IFormFile photo)
        {
            string fext = Path.GetExtension(photo.FileName);
            string uname = Guid.NewGuid().ToString();
            string fname = uname + fext;
            string fullpath = Path.Combine(_env.WebRootPath, "pictures\\" + fname);
            FileStream fs = new FileStream(fullpath, FileMode.Create);
            photo.CopyTo(fs);
            fs.Close();
            return fname;
        }

    }
}
