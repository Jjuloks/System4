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
            var list = await _context.Rezerwacja.ToListAsync();
            var model = new AdminPanelIndexViewModel { Rezerwacje = list };
            return View(model);
        }

        // Serve all reservations under /Admin-Panel/Rezerwacjie
        [HttpGet("Rezerwacjie")]
        public async Task<IActionResult> Rezerwacjie()
        {
            var list = await _context.Rezerwacja.ToListAsync();
            ViewBag.AdminPanel = true;
            return View("~/Views/Rezerwacje/Index.cshtml", list);
        }

        // Serve today's reservations under /Admin-Panel/Rezerwacjie/Today
        [HttpGet("Rezerwacjie/Today")]
        public async Task<IActionResult> RezerwacjieToday()
        {
            var today = DateTime.Today;
            var list = await _context.Rezerwacja
                .Where(x => x.ReservationDate.Date == today)
                .ToListAsync();
            ViewBag.AdminPanel = true;
            return View("~/Views/Rezerwacje/Index.cshtml", list);
        }

        [HttpGet("/Admin")]
        public IActionResult RedirectFromAdmin() => RedirectToAction(nameof(Index));
    }
}