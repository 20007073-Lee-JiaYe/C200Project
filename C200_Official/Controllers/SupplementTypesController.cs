using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using C200_Official.Models;

namespace C200_Official.Controllers
{
    public class SupplementTypesController : Controller
    {
        private readonly AppDbContext _context;

        public SupplementTypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: SupplementTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.SupplementTypes.ToListAsync());
        }

        // GET: SupplementTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplementType = await _context.SupplementTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplementType == null)
            {
                return NotFound();
            }

            return View(supplementType);
        }

        // GET: SupplementTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SupplementTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Benefits")] SupplementType supplementType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplementType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplementType);
        }

        // GET: SupplementTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplementType = await _context.SupplementTypes.FindAsync(id);
            if (supplementType == null)
            {
                return NotFound();
            }
            return View(supplementType);
        }

        // POST: SupplementTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Benefits")] SupplementType supplementType)
        {
            if (id != supplementType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplementType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplementTypeExists(supplementType.Id))
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
            return View(supplementType);
        }

        // GET: SupplementTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplementType = await _context.SupplementTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplementType == null)
            {
                return NotFound();
            }

            return View(supplementType);
        }

        // POST: SupplementTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplementType = await _context.SupplementTypes.FindAsync(id);
            _context.SupplementTypes.Remove(supplementType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplementTypeExists(int id)
        {
            return _context.SupplementTypes.Any(e => e.Id == id);
        }
    }
}
