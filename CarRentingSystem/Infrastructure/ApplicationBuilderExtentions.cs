﻿using CarRentingSystem.Data;
using CarRentingSystem.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentingSystem.Infrastructure
{
    public static class ApplicationBuilderExtentions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedSerives = app.ApplicationServices.CreateScope();
            var data = scopedSerives.ServiceProvider.GetService<CarRentingDbContext>();

            data.Database.Migrate();

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(CarRentingDbContext data)
        {
            if (data.Category.Any())
            {
                return;
            }

            data.Category.AddRange(new[]
            {
                new Category { Name = "Mini" },
                new Category { Name = "Economy" },
                new Category { Name = "Midsize" },
                new Category { Name = "Large" },
                new Category { Name = "SUV" },
                new Category { Name = "Vans" },
                new Category { Name = "Luxury" },
            });

            data.SaveChanges();
        }
    }
}
