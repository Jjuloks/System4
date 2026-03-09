using System.Collections.Generic;
using Projekt_Zarzadzanie_Rezerwacjami.Models;

namespace Projekt_Zarzadzanie_Rezerwacjami.ViewModels
{
    public class AdminPanelIndexViewModel
    {
        public List<Rezerwacja> Rezerwacje { get; set; } = new();
    }
}