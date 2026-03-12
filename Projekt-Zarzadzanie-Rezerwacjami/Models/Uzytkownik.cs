using System.ComponentModel.DataAnnotations;

namespace Projekt_Zarzadzanie_Rezerwacjami.Models
{
    public class Uzytkownik
    {
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}