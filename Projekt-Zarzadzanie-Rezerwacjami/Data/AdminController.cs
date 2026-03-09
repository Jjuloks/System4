using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt_Zarzadzanie_Rezerwacjami.Models;

namespace Projekt_Zarzadzanie_Rezerwacjami.Data
{
    public class AdminController : Controller
    {
        private readonly Projekt_Zarzadzanie_RezerwacjamiContext _context;

        public AdminController(Projekt_Zarzadzanie_RezerwacjamiContext context)
        {
            _context = context;
        }

        // Mapuje bezpośrednio /Admin
        [HttpGet("/Admin")]
        public async Task<IActionResult> Index()
        {
            var rezerwacje = await _context.Rezerwacja.ToListAsync();
            return View(rezerwacje);
        }

        // Obsługa linku z layoutu (jeśli ktoś używa asp-action="Admin")
        public IActionResult Admin()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}