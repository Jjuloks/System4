using System.ComponentModel.DataAnnotations;

namespace Projekt_Zarzadzanie_Rezerwacjami.Models
{
    public class Room
    {
        [Key]
        public int SalaId { get; set; }
        public string? salaName { get; set; }
        public int Capacity { get; set; }
        public bool HasTv { get; set; }

        public ICollection<Rezerwacja> Rezerwacje { get; set; } = new List<Rezerwacja>();
    }
        
}
