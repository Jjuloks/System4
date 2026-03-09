using Microsoft.AspNetCore.Mvc;
namespace Projekt_Zarzadzanie_Rezerwacjami.Views.Login
{
    public class IndexModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OnPost()
        {
            return RedirectToAction("/Rezerwacje/Index");
        }
    }
}
