﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WC7.Models;

namespace WC7.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Auditorium> Auditoria { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var movies = new List<Movie> {
                new Movie(1, "test title 1", 80, "test director 1"),
                new Movie(2, "test title 2", 100, "test director 2"),
                //new Movie {
                //    Id = 3,
                //    Title = "test title 3",
                //    Ranking = 100,
                //    DirectorName = "test director 3"
                //}
            };

            var auditoria = new List<Auditorium> {
                new Auditorium(1, 10),
                new Auditorium(2, 50)
            };

            var t = DateTime.Now;
            var tPlus2 = t.AddHours(2);
            var tPlus1Day = t.AddDays(1);
            var tPlus1DayPlus2 = tPlus1Day.AddHours(2);
            var tPlus1Week = t.AddDays(7);
            var tPlus1WeekPlus2 = tPlus1Week.AddHours(2);

            var screenings = new List<Screening> {
                // Today
                new Screening(1, auditoria[0].Id, movies[0].Id, t, tPlus2, auditoria[0].Capacity),
                // This week
                new Screening(2, auditoria[1].Id, movies[1].Id, tPlus1Day, tPlus1DayPlus2, auditoria[1].Capacity),
                // Next Week
                new Screening(3, auditoria[0].Id, movies[1].Id, tPlus1Week, tPlus1WeekPlus2, auditoria[0].Capacity)
            };

            builder.Entity<Movie>().HasData(movies);
            builder.Entity<Auditorium>().HasData(auditoria);
            builder.Entity<Screening>().HasData(screenings);
        }
    }
}
