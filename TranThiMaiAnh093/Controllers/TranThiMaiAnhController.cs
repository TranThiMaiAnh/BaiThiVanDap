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
    public class TranThiMaiAnhController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TranThiMaiAnhController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TranThiMaiAnh
        public async Task<IActionResult> Index()
        {
            return View(await _context.TranThiMaiAnh.ToListAsync());
        }

        // GET: TranThiMaiAnh/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranThiMaiAnh = await _context.TranThiMaiAnh
                .FirstOrDefaultAsync(m => m.Hovaten == id);
            if (tranThiMaiAnh == null)
            {
                return NotFound();
            }

            return View(tranThiMaiAnh);
        }

        // GET: TranThiMaiAnh/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TranThiMaiAnh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Hovaten,Tuoi,Diem")] TranThiMaiAnh tranThiMaiAnh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tranThiMaiAnh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tranThiMaiAnh);
        }

        // GET: TranThiMaiAnh/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranThiMaiAnh = await _context.TranThiMaiAnh.FindAsync(id);
            if (tranThiMaiAnh == null)
            {
                return NotFound();
            }
            return View(tranThiMaiAnh);
        }

        // POST: TranThiMaiAnh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Hovaten,Tuoi,Diem")] TranThiMaiAnh tranThiMaiAnh)
        {
            if (id != tranThiMaiAnh.Hovaten)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tranThiMaiAnh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TranThiMaiAnhExists(tranThiMaiAnh.Hovaten))
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
            return View(tranThiMaiAnh);
        }

        // GET: TranThiMaiAnh/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranThiMaiAnh = await _context.TranThiMaiAnh
                .FirstOrDefaultAsync(m => m.Hovaten == id);
            if (tranThiMaiAnh == null)
            {
                return NotFound();
            }

            return View(tranThiMaiAnh);
        }

        // POST: TranThiMaiAnh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tranThiMaiAnh = await _context.TranThiMaiAnh.FindAsync(id);
            if (tranThiMaiAnh != null)
            {
                _context.TranThiMaiAnh.Remove(tranThiMaiAnh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TranThiMaiAnhExists(string id)
        {
            return _context.TranThiMaiAnh.Any(e => e.Hovaten == id);
        }
    }
}
