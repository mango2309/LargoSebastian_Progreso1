using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LargoSebastian_Progreso1.Data;
using LargoSebastian_Progreso1.Models;

namespace LargoSebastian_Progreso1.Controllers
{
    public class LargoSController : Controller
    {
        private readonly LargoSebastian_Progreso1Context _context;

        public LargoSController(LargoSebastian_Progreso1Context context)
        {
            _context = context;
        }

        // GET: LargoS
        public async Task<IActionResult> Index()
        {
            return View(await _context.LargoS.ToListAsync());
        }

        // GET: LargoS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var largoS = await _context.LargoS
                .FirstOrDefaultAsync(m => m.IdNombre == id);
            if (largoS == null)
            {
                return NotFound();
            }

            return View(largoS);
        }

        // GET: LargoS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LargoS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNombre,Entero,Decimal,Palabra,VerdaderoFalso,Fecha")] LargoS largoS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(largoS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(largoS);
        }

        // GET: LargoS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var largoS = await _context.LargoS.FindAsync(id);
            if (largoS == null)
            {
                return NotFound();
            }
            return View(largoS);
        }

        // POST: LargoS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdNombre,Entero,Decimal,Palabra,VerdaderoFalso,Fecha")] LargoS largoS)
        {
            if (id != largoS.IdNombre)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(largoS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LargoSExists(largoS.IdNombre))
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
            return View(largoS);
        }

        // GET: LargoS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var largoS = await _context.LargoS
                .FirstOrDefaultAsync(m => m.IdNombre == id);
            if (largoS == null)
            {
                return NotFound();
            }

            return View(largoS);
        }

        // POST: LargoS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var largoS = await _context.LargoS.FindAsync(id);
            if (largoS != null)
            {
                _context.LargoS.Remove(largoS);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LargoSExists(int id)
        {
            return _context.LargoS.Any(e => e.IdNombre == id);
        }
    }
}
