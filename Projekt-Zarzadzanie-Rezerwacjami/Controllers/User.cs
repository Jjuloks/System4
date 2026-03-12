using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt_Zarzadzanie_Rezerwacjami.Data;
using Projekt_Zarzadzanie_Rezerwacjami.Helpers;
using Projekt_Zarzadzanie_Rezerwacjami.Models;
namespace Projekt_Zarzadzanie_Rezerwacjami.Controllers
{
    [AuthorizeSession("user")]
    public class User : Controller
    {
        private readonly Projekt_Zarzadzanie_RezerwacjamiContext _context;

        public User(Projekt_Zarzadzanie_RezerwacjamiContext context)
        {
            _context = context;
        }
        // GET: UserController1
        public ActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> TodayU()

        {

            var today_Date = DateTime.Today;

            var rezerwacjeNaDzis = await _context.Rezerwacja

                .Where(x => x.ReservationDate.Date == today_Date).Include(r => r.Room)

                .ToListAsync();

            var todayModel = new Models.TodayModel { Rezerwacje = rezerwacjeNaDzis };

            return View(todayModel);

        }

        // GET: UserController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController1/Create
        public ActionResult Create()
        {
            return View();
        }
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
        // POST: UserController1/Create


        // GET: UserController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
