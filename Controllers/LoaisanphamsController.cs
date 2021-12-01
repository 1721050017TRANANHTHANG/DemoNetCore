using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class LoaisanphamsController : Controller
    {
        private readonly MvcMovieContext _context;

        public LoaisanphamsController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Loaisanphams
        public async Task<IActionResult> Index()
        {
            return View(await _context.Loaisanpham.ToListAsync());
        }

        // GET: Loaisanphams/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaisanpham = await _context.Loaisanpham
                .FirstOrDefaultAsync(m => m.lspID == id);
            if (loaisanpham == null)
            {
                return NotFound();
            }

            return View(loaisanpham);
        }

        // GET: Loaisanphams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Loaisanphams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("lspID,tenloai")] Loaisanpham loaisanpham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaisanpham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaisanpham);
        }

        // GET: Loaisanphams/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaisanpham = await _context.Loaisanpham.FindAsync(id);
            if (loaisanpham == null)
            {
                return NotFound();
            }
            return View(loaisanpham);
        }

        // POST: Loaisanphams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("lspID,tenloai")] Loaisanpham loaisanpham)
        {
            if (id != loaisanpham.lspID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaisanpham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaisanphamExists(loaisanpham.lspID))
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
            return View(loaisanpham);
        }

        // GET: Loaisanphams/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaisanpham = await _context.Loaisanpham
                .FirstOrDefaultAsync(m => m.lspID == id);
            if (loaisanpham == null)
            {
                return NotFound();
            }

            return View(loaisanpham);
        }

        // POST: Loaisanphams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var loaisanpham = await _context.Loaisanpham.FindAsync(id);
            _context.Loaisanpham.Remove(loaisanpham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaisanphamExists(string id)
        {
            return _context.Loaisanpham.Any(e => e.lspID == id);
        }
    }
}
