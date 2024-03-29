﻿using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class ClothConfiguration : IEntityTypeConfiguration<Cloth>
    {
        private readonly bool seedDb;

        public ClothConfiguration(bool seedDb = true)
        {
            this.seedDb = seedDb;
        }

        public void Configure(EntityTypeBuilder<Cloth> builder)
        {
            builder
                .HasOne(p => p.Category)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Images)
                .WithOne(i => i.Cloth)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Reviews)
                .WithOne(r => r.Cloth)
                .OnDelete(DeleteBehavior.Restrict);

            if (seedDb)
            {
                builder
                    .HasData(CreateCloths());
            }
        }

        private static List<Cloth> CreateCloths()
        {
            return new List<Cloth>()
            {
                new Cloth()
                {
                    Id = 1,
                    PackageId = "DE3F5A08-C6EA-473D-977E-975E80D2C664",
                    Name = "Tениска",
                    Brand = "Nike",
                    Price = 58.90m,
                    Description = "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.",
                    Quantity = 10,
                    CategoryId = 1,
                    ColorId = 2,
                    ForKids = false,
                    Gender = Gender.Male,
                },
                new Cloth()
                {
                    Id = 2,
                    PackageId = "DE3F5A08-C6EA-473D-977E-975E80D2C664",
                    Name = "Tениска",
                    Brand = "Nike",
                    Price = 58.90m,
                    Description = "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.",
                    Quantity = 10,
                    CategoryId = 1,
                    ColorId = 11,
                    ForKids = false,
                    Gender = Gender.Male,
                },
                new Cloth()
                {
                    Id = 3,
                    PackageId = "DE3F5A08-C6EA-473D-977E-975E80D2C664",
                    Name = "Tениска",
                    Brand = "Nike",
                    Price = 58.90m,
                    Description = "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.",
                    Quantity = 10,
                    CategoryId = 1,
                    ColorId = 5,
                    ForKids = false,
                    Gender = Gender.Male,
                },
                new Cloth()
                {
                    Id = 4,
                    PackageId = "DE3F5A08-C6EA-473D-977E-975E80D2C664",
                    Name = "Tениска",
                    Brand = "Nike",
                    Price = 58.90m,
                    Description = "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.",
                    Quantity = 10,
                    CategoryId = 1,
                    ColorId = 3,
                    ForKids = false,
                    Gender = Gender.Male,
                },
                new Cloth()
                {
                    Id = 5,
                    PackageId = "4C6AC916-30A6-4962-ACA9-67BFA417FF31",
                    Name = "Тениска",
                    Brand = "Polo Ralph Lauren",
                    Price = 232.90m,
                    Description = "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities",
                    Quantity = 7,
                    CategoryId = 1,
                    ColorId = 11,
                    ForKids = false,
                    Gender = Gender.Male
                },
                new Cloth()
                {
                    Id = 6,
                    PackageId = "4C6AC916-30A6-4962-ACA9-67BFA417FF31",
                    Name = "Тениска",
                    Brand = "Polo Ralph Lauren",
                    Price = 232.90m,
                    Description = "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities",
                    Quantity = 7,
                    CategoryId = 1,
                    ColorId = 5,
                    ForKids = false,
                    Gender = Gender.Male
                },
                new Cloth()
                {
                    Id = 7,
                    PackageId = "EE2D09B8-6FC5-4BBD-857D-669448F72A8E",
                    Name = "Тениска 'DESTINY'",
                    Brand = "JACK & JONES",
                    Price = 34.90m,
                    Description = "This T-Shirt is the best that Jack&Jones have ever created. Perfect for outdoor activities",
                    Quantity = 5,
                    CategoryId = 1,
                    ColorId = 11,
                    ForKids = false,
                    Gender = Gender.Male
                },
                new Cloth()
                {
                    Id = 8,
                    PackageId = "EE2D09B8-6FC5-4BBD-857D-669448F72A8E",
                    Name = "Тениска 'DESTINY'",
                    Brand = "JACK & JONES",
                    Price = 34.90m,
                    Description = "This T-Shirt is the best that Jack&Jones have ever created. Perfect for outdoor activities",
                    Quantity = 7,
                    CategoryId = 1,
                    ColorId = 1,
                    ForKids = false,
                    Gender = Gender.Male
                },
                new Cloth()
                {
                    Id = 9,
                    PackageId = "EE2D09B8-6FC5-4BBD-857D-669448F72A8E",
                    Name = "Тениска 'DESTINY'",
                    Brand = "JACK & JONES",
                    Price = 34.90m,
                    Description = "This T-Shirt is the best that Jack&Jones have ever created. Perfect for outdoor activities",
                    Quantity = 4,
                    CategoryId = 1,
                    ColorId = 9,
                    ForKids = false,
                    Gender = Gender.Male
                },
                new Cloth()
                {
                    Id = 10,
                    PackageId = "705B0C81-D166-4127-8C1A-D956CA797BDB",
                    Name = "Regular fit Тениска",
                    Brand = "TOMMY HILFIGER",
                    Price = 157.90m,
                    Description = "This T-Shirt is the best that Tommy Hilfiger have ever created. Perfect for dates",
                    Quantity = 10,
                    CategoryId = 1,
                    ColorId = 2,
                    ForKids = false,
                    Gender = Gender.Male
                }
            };
        }
    }
}
