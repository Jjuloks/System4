using System.ComponentModel.DataAnnotations;
using System.Linq;
using Projekt_Zarzadzanie_Rezerwacjami.Data;

namespace Projekt_Zarzadzanie_Rezerwacjami.Models
{
    public class RoomCapacityAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var reservation = (Rezerwacja)validationContext.ObjectInstance;

            var context = (Projekt_Zarzadzanie_RezerwacjamiContext)
                validationContext.GetService(typeof(Projekt_Zarzadzanie_RezerwacjamiContext));

            if (context == null)
                return ValidationResult.Success;

            if (reservation.Sala == null)
                return ValidationResult.Success;

            int roomId = (int)reservation.Sala - 1;

            var room = context.Room.FirstOrDefault(r => r.SalaId == roomId);

            if (room == null)
                return ValidationResult.Success;

            if (reservation.Rozmiar > room.Capacity)
            {
                return new ValidationResult($"Room capacity is {room.Capacity}. Too many people.");
            }

            return ValidationResult.Success;
        }
    }
}