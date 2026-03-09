using Microsoft.AspNetCore.Mvc;

namespace Projekt_Zarzadzanie_Rezerwacjami.Controllers
{
    public class Admin_Panel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
