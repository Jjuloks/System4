
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [NotPastDate(ErrorMessage = "Date cannot be in the past.")]
        public DateTime ReservationDate { get; set; }
        [DataType(DataType.Date)]


        [Required]
        public DateTime Duration { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rozmiar { get; set; }
        [Required]
        public Boolean IsExclusive { get; set; }
    }
}
