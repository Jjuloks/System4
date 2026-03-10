using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projekt_Zarzadzanie_Rezerwacjami.Data;
using System;
using System.Linq;
namespace Projekt_Zarzadzanie_Rezerwacjami.Models;
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Projekt_Zarzadzanie_RezerwacjamiContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Projekt_Zarzadzanie_RezerwacjamiContext>>()))
            {
                if (context.Rezerwacja.Any())
                {
                    return;
                }
            context.Rezerwacja.AddRange(
               new Rezerwacja
               {
                   Name = "Jan Kowalski",
                   ReservationDate = DateTime.Parse("2026-03-10 17:00"),
                   Duration = DateTime.Parse("02:00"),
                   Rozmiar = 4,
                   Sala = Sala.S01,
                   IsExclusive = false
               },
                new Rezerwacja
                {
                    Name = "Anna Nowak",
                    ReservationDate = DateTime.Parse("2026-03-10 19:30"),
                    Duration = DateTime.Parse("01:30"),
                    Rozmiar = 2,
                    Sala = Sala.S02,
                    IsExclusive = true
                },
                new Rezerwacja
                {
                    Name = "Piotr Wiśnki",
                    ReservationDate = DateTime.Parse("2026-03-11 18:00"),
                    Duration = DateTime.Parse("03:00"),
                    Rozmiar = 6,
                    Sala = Sala.S03,
                    IsExclusive = false
                }
                
            );
                context.SaveChanges();
            }
        }
    }
