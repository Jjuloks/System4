using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Projekt_Zarzadzanie_Rezerwacjami.Helpers
{
    public class AuthorizeSessionAttribute : ActionFilterAttribute
    {
        private readonly string _role;

        public AuthorizeSessionAttribute(string role)
        {
            _role = role;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var roleInSession = context.HttpContext.Session.GetString("role");

            if (string.IsNullOrEmpty(roleInSession) || roleInSession != _role)
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }

            base.OnActionExecuting(context);
        }
    }
}