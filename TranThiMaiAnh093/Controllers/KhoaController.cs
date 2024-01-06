using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranThiMaiAnh093;
using TranThiMaiAnh093.Data;

namespace TranThiMaiAnh093.Controllers
{
    public class KhoaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KhoaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Khoa
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Khoa.Include(k => k.Hoten);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Khoa/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoa = await _context.Khoa
                .Include(k => k.Hoten)
                .FirstOrDefaultAsync(m => m.MaKhoa == id);
            if (khoa == null)
            {
                return NotFound();
            }

            return View(khoa);
        }

        // GET: Khoa/Create
        public IActionResult Create()
        {
            ViewData["Hovaten"] = new SelectList(_context.TranThiMaiAnh, "Hovaten", "Hovaten");
            return View();
        }

        // POST: Khoa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKhoa,TenKhoa,SoDienThoai,Hovaten")] Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Hovaten"] = new SelectList(_context.TranThiMaiAnh, "Hovaten", "Hovaten", khoa.Hovaten);
            return View(khoa);
        }

        // GET: Khoa/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoa = await _context.Khoa.FindAsync(id);
            if (khoa == null)
            {
                return NotFound();
            }
            ViewData["Hovaten"] = new SelectList(_context.TranThiMaiAnh, "Hovaten", "Hovaten", khoa.Hovaten);
            return View(khoa);
        }

        // POST: Khoa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaKhoa,TenKhoa,SoDienThoai,Hovaten")] Khoa khoa)
        {
            if (id != khoa.MaKhoa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoaExists(khoa.MaKhoa))
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
            ViewData["Hovaten"] = new SelectList(_context.TranThiMaiAnh, "Hovaten", "Hovaten", khoa.Hovaten);
            return View(khoa);
        }

        // GET: Khoa/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoa = await _context.Khoa
                .Include(k => k.Hoten)
                .FirstOrDefaultAsync(m => m.MaKhoa == id);
            if (khoa == null)
            {
                return NotFound();
            }

            return View(khoa);
        }

        // POST: Khoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khoa = await _context.Khoa.FindAsync(id);
            if (khoa != null)
            {
                _context.Khoa.Remove(khoa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoaExists(string id)
        {
            return _context.Khoa.Any(e => e.MaKhoa == id);
        }
    }
}
