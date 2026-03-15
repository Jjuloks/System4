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
                },
                new Rezerwacja
                {
                    Name = "Piotr Zieliński",
                    ReservationDate = DateTime.Parse("2026-03-16 15:00"),
                    Rozmiar = 3,
                    Sala = Sala.S02,
                    IsExclusive = false,
                    Duration = Duration.duration2,
                    RoomId = 1,
                },
new Rezerwacja
{
    Name = "Jan Kowalski",
    ReservationDate = DateTime.Parse("2026-03-16 15:00"),
    Rozmiar = 4,
    Sala = Sala.S01,
    IsExclusive = false,
    Duration = Duration.duration2,
    RoomId = 0,
},
new Rezerwacja
{
    Name = "Anna Nowak",
    ReservationDate = DateTime.Parse("2026-03-16 16:30"),
    Rozmiar = 2,
    Sala = Sala.S02,
    IsExclusive = true,
    Duration = Duration.duration1,
    RoomId = 1,
},
new Rezerwacja
{
    Name = "Piotr Mazur",
    ReservationDate = DateTime.Parse("2026-03-16 18:00"),
    Rozmiar = 5,
    Sala = Sala.S03,
    IsExclusive = false,
    Duration = Duration.duration2,
    RoomId = 2,
},
new Rezerwacja
{
    Name = "Ewa Król",
    ReservationDate = DateTime.Parse("2026-03-16 19:30"),
    Rozmiar = 3,
    Sala = Sala.S04,
    IsExclusive = true,
    Duration = Duration.duration2,
    RoomId = 3,
},
new Rezerwacja
{
    Name = "Adam Lis",
    ReservationDate = DateTime.Parse("2026-03-17 14:00"),
    Rozmiar = 6,
    Sala = Sala.S05,
    IsExclusive = false,
    Duration = Duration.duration3,
    RoomId = 4,
},
new Rezerwacja
{
    Name = "Ola Kaczmarek",
    ReservationDate = DateTime.Parse("2026-03-17 15:30"),
    Rozmiar = 2,
    Sala = Sala.S01,
    IsExclusive = false,
    Duration = Duration.duration1,
    RoomId = 0,
},
new Rezerwacja
{
    Name = "Tomasz Bąk",
    ReservationDate = DateTime.Parse("2026-03-18 12:00"),
    Rozmiar = 7,
    Sala = Sala.S06,
    IsExclusive = true,
    Duration = Duration.duration3,
    RoomId = 5,
},
new Rezerwacja
{
    Name = "Marta Pawlak",
    ReservationDate = DateTime.Parse("2026-03-18 16:00"),
    Rozmiar = 3,
    Sala = Sala.S02,
    IsExclusive = false,
    Duration = Duration.duration2,
    RoomId = 1,
},
new Rezerwacja
{
    Name = "Paweł Baran",
    ReservationDate = DateTime.Parse("2026-03-19 18:30"),
    Rozmiar = 4,
    Sala = Sala.S03,
    IsExclusive = true,
    Duration = Duration.duration2,
    RoomId = 2,
},
new Rezerwacja
{
    Name = "Kasia Zając",
    ReservationDate = DateTime.Parse("2026-03-19 13:00"),
    Rozmiar = 2,
    Sala = Sala.S04,
    IsExclusive = false,
    Duration = Duration.duration1,
    RoomId = 3,
},
new Rezerwacja
{
    Name = "Rafał Kubiak",
    ReservationDate = DateTime.Parse("2026-03-20 15:30"),
    Rozmiar = 8,
    Sala = Sala.S05,
    IsExclusive = true,
    Duration = Duration.duration3,
    RoomId = 4,
},
new Rezerwacja
{
    Name = "Ola Mazur",
    ReservationDate = DateTime.Parse("2026-03-20 17:00"),
    Rozmiar = 4,
    Sala = Sala.S06,
    IsExclusive = false,
    Duration = Duration.duration2,
    RoomId = 5,
},
new Rezerwacja
{
    Name = "Bartek Lis",
    ReservationDate = DateTime.Parse("2026-03-21 14:30"),
    Rozmiar = 3,
    Sala = Sala.S01,
    IsExclusive = false,
    Duration = Duration.duration1,
    RoomId = 0,
},
new Rezerwacja
{
    Name = "Julia Król",
    ReservationDate = DateTime.Parse("2026-03-21 19:00"),
    Rozmiar = 6,
    Sala = Sala.S02,
    IsExclusive = true,
    Duration = Duration.duration2,
    RoomId = 1,
},
new Rezerwacja
{
    Name = "Marek Wójcik",
    ReservationDate = DateTime.Parse("2026-03-22 12:30"),
    Rozmiar = 2,
    Sala = Sala.S03,
    IsExclusive = false,
    Duration = Duration.duration1,
    RoomId = 2,
},
new Rezerwacja
{
    Name = "Natalia Dudek",
    ReservationDate = DateTime.Parse("2026-03-22 18:00"),
    Rozmiar = 5,
    Sala = Sala.S04,
    IsExclusive = true,
    Duration = Duration.duration3,
    RoomId = 3,
},
new Rezerwacja
{
    Name = "Kuba Kaczor",
    ReservationDate = DateTime.Parse("2026-03-23 16:30"),
    Rozmiar = 4,
    Sala = Sala.S05,
    IsExclusive = false,
    Duration = Duration.duration2,
    RoomId = 4,
},
new Rezerwacja
{
    Name = "Ewa Mazur",
    ReservationDate = DateTime.Parse("2026-03-23 20:00"),
    Rozmiar = 3,
    Sala = Sala.S06,
    IsExclusive = false,
    Duration = Duration.duration1,
    RoomId = 5,
},
new Rezerwacja
{
    Name = "Damian Bąk",
    ReservationDate = DateTime.Parse("2026-03-24 17:30"),
    Rozmiar = 9,
    Sala = Sala.S01,
    IsExclusive = true,
    Duration = Duration.duration3,
    RoomId = 0,
},
new Rezerwacja
{
    Name = "Ala Góral",
    ReservationDate = DateTime.Parse("2026-03-24 14:00"),
    Rozmiar = 2,
    Sala = Sala.S02,
    IsExclusive = false,
    Duration = Duration.duration1,
    RoomId = 1,
}
);
                context.SaveChanges();
            }
        }
    }
