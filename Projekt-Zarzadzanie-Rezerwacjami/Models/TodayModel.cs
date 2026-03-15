using Projekt_Zarzadzanie_Rezerwacjami.Models;
using System.Collections.Generic;

namespace Projekt_Zarzadzanie_Rezerwacjami.Models
{
    public class TodayModel
    {
        public required List<Rezerwacja> Rezerwacje { get => field; set => field = value; }
    }
}
