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
        public DbSet<Projekt_Zarzadzanie_Rezerwacjami.Models.Room> Room { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Room>()
                .HasKey(r => r.SalaId);

            modelBuilder.Entity<Rezerwacja>()
                .HasOne(r => r.Room)
                .WithMany(rm => rm.Rezerwacje)
                .HasForeignKey(r => r.RoomId)
                .HasPrincipalKey(rm => rm.SalaId);
        }
    }

}

