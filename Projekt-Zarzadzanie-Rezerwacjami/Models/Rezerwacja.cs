
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
        public DateTime ReservationDate { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rozmiar { get; set; }
        
 
        public Sala? Sala { get; set; }

        public Boolean IsExclusive { get; set; }

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
    S01,
    S02,
    S03,
    S04,
    S05,
    S06
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


