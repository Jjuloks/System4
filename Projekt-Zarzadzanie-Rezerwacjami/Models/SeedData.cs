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
                   Rozmiar = 4,
                   Sala = Sala.S01,
                   IsExclusive = false,
                   Duration = Duration.duration3,
                   RoomId = 0,
               },
                new Rezerwacja
                {
                    Name = "Anna Nowak",
                    ReservationDate = DateTime.Parse("2026-03-10 19:30"),
                    Rozmiar = 2,
                    Sala = Sala.S02,
                    IsExclusive = true,
                    Duration = Duration.duration2,
                    RoomId = 1,
                },
                new Rezerwacja
                {
                    Name = "GOATGA",
                    ReservationDate = DateTime.Parse("2026-03-10 19:30"),
                    Rozmiar = 4,
                    Sala = Sala.S05,
                    IsExclusive = true,
                    Duration = Duration.duration2,
                    RoomId = 4,
                }


            );
                context.SaveChanges();
            }
        }
    }
