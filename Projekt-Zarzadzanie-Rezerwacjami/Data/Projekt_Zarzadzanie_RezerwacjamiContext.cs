using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt_Zarzadzanie_Rezerwacjami.Models;

namespace Projekt_Zarzadzanie_Rezerwacjami.Data
{
    public class Projekt_Zarzadzanie_RezerwacjamiContext : DbContext
    {
        public Projekt_Zarzadzanie_RezerwacjamiContext (DbContextOptions<Projekt_Zarzadzanie_RezerwacjamiContext> options)
            : base(options)
        {
        }

        public DbSet<Projekt_Zarzadzanie_Rezerwacjami.Models.Rezerwacja> Rezerwacja { get; set; } = default!;
    }
}
