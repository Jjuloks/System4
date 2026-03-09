using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt_Zarzadzanie_Rezerwacjami.ViewModels;
using Projekt_Zarzadzanie_Rezerwacjami.Models;

namespace Projekt_Zarzadzanie_Rezerwacjami.Data
{
    [Route("Admin-Panel")]
    public class AdminPanelController : Controller
    {
        private readonly Projekt_Zarzadzanie_RezerwacjamiContext _context;

        public AdminPanelController(Projekt_Zarzadzanie_RezerwacjamiContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rezerwacja.ToListAsync());
        }

        // Serve all reservations under /Admin-Panel/Rezerwacjie
  
        public async Task<IActionResult> Rezerwacjie()
        {
            var list = await _context.Rezerwacja.ToListAsync();

            return View("Index", list);
        }

        // Serve today's reservations under /Admin-Panel/Rezerwacjie/Today
        public async Task<IActionResult> Rezerwacje11()
        {
            var today_Date = DateTime.Today;

            var rezerwacjeNaDzis = await _context.Rezerwacja
                .Where(x => x.ReservationDate.Date == today_Date)
                .ToListAsync();

            return View("Index", rezerwacjeNaDzis);
        }

  
        public IActionResult RedirectFromAdmin() => RedirectToAction(nameof(Index));
    }
}