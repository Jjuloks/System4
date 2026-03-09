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
                       IsExclusive = false
                   },
                    new Rezerwacja
                    {
                        Name = "Anna Nowak",
                        ReservationDate = DateTime.Parse("2026-03-10 19:30"),
                        Duration = DateTime.Parse("01:30"),
                        Rozmiar = 2,
                        IsExclusive = true
                    },
                    new Rezerwacja
                    {
                        Name = "Piotr Wiśniewski",
                        ReservationDate = DateTime.Parse("2026-03-11 18:00"),
                        Duration = DateTime.Parse("03:00"),
                        Rozmiar = 6,
                        IsExclusive = false
                    },
                    new Rezerwacja
                    {
                        Name = "Katarzyna Zielińska",
                        ReservationDate = DateTime.Parse("2026-03-11 17:30"),
                        Duration = DateTime.Parse("02:00"),
                        Rozmiar = 3,
                        IsExclusive = true
                    },
                        new Rezerwacja
                        {
                            Name = "Tomasz Lewandowski",
                            ReservationDate = DateTime.Parse("2026-03-12 18:00"),
                            Duration = DateTime.Parse("01:30"),
                            Rozmiar = 2,
                            IsExclusive = false
                        },
                        new Rezerwacja
                        {
                            Name = "Magdalena Kaczmarek",
                            ReservationDate = DateTime.Parse("2026-03-12 20:00"),
                            Duration = DateTime.Parse("02:00"),
                            Rozmiar = 5,
                            IsExclusive = true
                        },
                        new Rezerwacja
                        {
                            Name = "Paweł Mazur",
                            ReservationDate = DateTime.Parse("2026-03-13 17:00"),
                            Duration = DateTime.Parse("01:30"),
                            Rozmiar = 4,
                            IsExclusive = false
                        },
                        new Rezerwacja
                        {
                            Name = "Agnieszka Dąbrowska",
                            ReservationDate = DateTime.Parse("2026-03-13 19:00"),
                            Duration = DateTime.Parse("02:00"),
                            Rozmiar = 3,
                            IsExclusive = true
                        },
                        new Rezerwacja
                        {
                            Name = "Marek Wójcik",
                            ReservationDate = DateTime.Parse("2026-03-14 18:30"),
                            Duration = DateTime.Parse("01:30"),
                            Rozmiar = 2,
                            IsExclusive = false
                        },
                        new Rezerwacja
                        {
                            Name = "Ewa Kamińska",
                            ReservationDate = DateTime.Parse("2026-03-14 20:00"),
                            Duration = DateTime.Parse("02:00"),
                            Rozmiar = 4,
                            IsExclusive = true
                        }
                );
                context.SaveChanges();
            }
        }
    }
