using Microsoft.AspNetCore.Mvc;

namespace Projekt_Zarzadzanie_Rezerwacjami.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
