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
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace C200_Official.Controllers
{
    public class ProgrammesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProgrammesController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _env = environment;
        }

        // GET: Programmes
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Programmes.Include(p => p.Category);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Programmes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programme = await _context.Programmes
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (programme == null)
            {
                return NotFound();
            }

            return View(programme);
        }

        // GET: Programmes/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Programmes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,PicFile,Description,Link,CategoryId")] Programme programme, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                programme.Status = "Published";
                // Upload photo
                string fname = DoPhotoUpload(image);
                programme.PicFile = fname;
                _context.Add(programme);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Programme sucessfully posted.";
                TempData["MsgType"] = "success";
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", programme.CategoryId);
            return View(programme);
        }

        // GET: Programmes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programme = await _context.Programmes.FindAsync(id);
            if (programme == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", programme.CategoryId);
            return View(programme);
        }

        // POST: Programmes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,PicFile,Description,Link,CategoryId")] Programme programme, IFormFile image)
        {
            if (id != programme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                IFormCollection form = HttpContext.Request.Form;
                string tickpic = form["chkpic"].ToString().Trim();
                string fname = DoPhotoUpload(image);
                programme.PicFile = fname;



                try
                {
                    programme.Status = "Published";
                    _context.Update(programme);
                    await _context.SaveChangesAsync();
                    TempData["Msg"] = "Programme information being updated successfully.";
                    TempData["MsgType"] = "success";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgrammeExists(programme.Id))
                    {
                        TempData["Msg"] = "Programme ID not found!";
                        TempData["MsgType"] = "danger";
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", programme.CategoryId);
            return View(programme);
        }

        public IActionResult Delete(int id)
        {
            DbSet<Programme> dbs = _context.Programmes;

            Programme program = dbs.Where(so => so.Id == id).FirstOrDefault();

            if (program != null)
            {
                _context.Programmes.Remove(program);
                _context.SaveChanges();
                TempData["Message"] = "Programme information being deleted successfully.";
                TempData["MsgType"] = "success";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Programme ID not found!";
                TempData["MsgType"] = "danger";
                return RedirectToAction("Index");
            }
        }

        private bool ProgrammeExists(int id)
        {
            return _context.Programmes.Any(e => e.Id == id);
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
