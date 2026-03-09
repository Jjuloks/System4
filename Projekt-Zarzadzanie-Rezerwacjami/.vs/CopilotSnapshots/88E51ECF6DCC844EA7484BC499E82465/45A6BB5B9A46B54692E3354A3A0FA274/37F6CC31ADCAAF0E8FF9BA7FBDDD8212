using Azure.Messaging;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

using Projekt_Zarzadzanie_Rezerwacjami.Models;

namespace Projekt_Zarzadzanie_Rezerwacjami.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public IActionResult Logowanie(string login, string password)
        {
            if (login == "admin" && password == "admin")
            {
                return RedirectToAction("","Admin-Panel");
            }
            if (login == "user" && password == "user")
            {
                //Tu do Usera
                return RedirectToAction("", "Rezerwacje");
            }
            ViewBag.Error = "Niepoprawny dane logowania";
            return View("Index");
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }

      
    }
}
