using Projekt_Zarzadzanie_Rezerwacjami.Data;
using System.ComponentModel.DataAnnotations;

namespace Projekt_Zarzadzanie_Rezerwacjami.Models
{
    public class Uzytkownik
    {
        public class ValidLoginAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var uzytkownicy = (Uzytkownik)validationContext.ObjectInstance;
                var context = (Projekt_Zarzadzanie_RezerwacjamiContext)validationContext.GetService(typeof(Projekt_Zarzadzanie_RezerwacjamiContext));

                string login = uzytkownicy.Login;
              

                bool conflict = context.Uzytkownik.Any(r =>
                    r.Login == uzytkownicy.Login
                );

                if (conflict)
                {
                    return new ValidationResult("This username is already used.");
                }

                return ValidationResult.Success;
            }
        }
        public int Id { get; set; }

        [Required]
        [ValidLogin(ErrorMessage = "This username is already in use.")]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}