using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt_Zarzadzanie_Rezerwacjami.Data;
 
namespace Projekt_Zarzadzanie_Rezerwacjami.Controllers
{
    public class LoginController : Controller
    {
        private readonly Projekt_Zarzadzanie_RezerwacjamiContext _context;

        public LoginController(Projekt_Zarzadzanie_RezerwacjamiContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logowanie(string login, string password)
        {
            var user = await _context.Uzytkownik
                .FirstOrDefaultAsync(x => x.Login == login && x.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("role", user.Role);
                HttpContext.Session.SetString("login", user.Login);

                if (user.Role == "admin")
                    return RedirectToAction("Index", "Rezerwacje");

                if (user.Role == "user")
                    return RedirectToAction("Index", "User");
            }

            ViewBag.Error = "Niepoprawne dane logowania";
            return View("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}