
using Projekt_Zarzadzanie_Rezerwacjami.Data;
using Projekt_Zarzadzanie_Rezerwacjami.Migrations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Projekt_Zarzadzanie_Rezerwacjami.Models
  
{

    public class NotPastDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            DateTime date = (DateTime)value;
            return date >= DateTime.Now;
        }
    }
    
public class ValidDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var reservation = (Rezerwacja)validationContext.ObjectInstance;
            var context = (Projekt_Zarzadzanie_RezerwacjamiContext)validationContext.GetService(typeof(Projekt_Zarzadzanie_RezerwacjamiContext));

            if (reservation.Duration == null)
            {
                return ValidationResult.Success;
            }

            DateTime start = reservation.ReservationDate;
            DateTime end = reservation.ReservationDate.AddMinutes((int)reservation.Duration);

            bool conflict = context.Rezerwacja.Any(r =>
                r.Sala == reservation.Sala &&
                r.ReservationDate.Date == start.Date &&
                start < r.ReservationDate.AddMinutes((int)r.Duration) &&
                end > r.ReservationDate
            );

            if (conflict)
            {
                return new ValidationResult("This room is already reserved at this time.");
            }

            return ValidationResult.Success;
        }
    }

    public class Rezerwacja
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string? Name { get; set; }


        [Required]
        [DisplayName("Reservation Date")]
        [DataType(DataType.DateTime)]
        [NotPastDate(ErrorMessage= "Date cannot be in the past.")]
        [ValidDate(ErrorMessage = "This room is already reserved during that time.")]
        public DateTime ReservationDate { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rozmiar { get; set; }
        
 
        public Sala? Sala { get; set; }

        public Boolean IsExclusive { get; set; }

        [Required]
        public Duration? Duration { get; set; }


        [DisplayName("EndReservation Date")]
        public DateTime? EndReservationDate
        {
            get
            {
                if (Duration == null)
                    return null;

                return ReservationDate.AddMinutes((int)Duration);
            }
        }

        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room? Room { get; set; }
    }


}




 public enum Sala
{
    S01 = 1,
    S02 = 2,
    S03 = 3,
    S04 = 4,
    S05 = 5,
    S06 = 6
}
public enum Duration
{
    [Display(Name = "15 Minutes")]
    duration1 = 15,
    [Display(Name = "30 Minutes")]
    duration2 = 30,
    [Display(Name = "45 Minutes")]
    duration3 = 45,
    [Display(Name = "60 Minutes")]
    duration4 = 60,
    [Display(Name = "75 Minutes")]
    duration5 = 75,
    [Display(Name = "90 Minutes")]
    duration6 = 90

}


