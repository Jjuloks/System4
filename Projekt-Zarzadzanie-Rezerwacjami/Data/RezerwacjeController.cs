using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Projekt_Zarzadzanie_Rezerwacjami.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zarzadzanie_Rezerwacjami.Data
{
    public class RezerwacjeController : Controller
    {
        private readonly Projekt_Zarzadzanie_RezerwacjamiContext _context;

        public RezerwacjeController(Projekt_Zarzadzanie_RezerwacjamiContext context)
        {
            _context = context;
        }
       
        // GET: Rezerwacje
        public async Task<IActionResult> Index()
        {

            return View(await _context.Rezerwacja.ToListAsync());
        }

        public async Task<IActionResult> Today()
        {
            var today_Date = DateTime.Today;

            var rezerwacjeNaDzis = await _context.Rezerwacja
                .Where(x => x.ReservationDate.Date == today_Date)
                .ToListAsync();

            return View("Index", rezerwacjeNaDzis);
        }
        // GET: Rezerwacje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezerwacja = await _context.Rezerwacja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rezerwacja == null)
            {
                return NotFound();
            }

            return View(rezerwacja);
        }

        // GET: Rezerwacje/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rezerwacje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ReservationDate,Duration,Rozmiar,IsExclusive")] Rezerwacja rezerwacja)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rezerwacja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rezerwacja);
        }

        // GET: Rezerwacje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezerwacja = await _context.Rezerwacja.FindAsync(id);
            if (rezerwacja == null)
            {
                return NotFound();
            }
            return View(rezerwacja);
        }

        // POST: Rezerwacje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ReservationDate,Duration,Rozmiar,IsExclusive")] Rezerwacja rezerwacja)
        {
            if (id != rezerwacja.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rezerwacja);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezerwacjaExists(rezerwacja.Id))
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
            return View(rezerwacja);
        }

        // GET: Rezerwacje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezerwacja = await _context.Rezerwacja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rezerwacja == null)
            {
                return NotFound();
            }

            return View(rezerwacja);
        }

        // POST: Rezerwacje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezerwacja = await _context.Rezerwacja.FindAsync(id);
            if (rezerwacja != null)
            {
                _context.Rezerwacja.Remove(rezerwacja);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RezerwacjaExists(int id)
        {
            return _context.Rezerwacja.Any(e => e.Id == id);
        }
    }
}
