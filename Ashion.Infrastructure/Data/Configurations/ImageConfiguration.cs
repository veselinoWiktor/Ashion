using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        private readonly bool seedDb;

        public ImageConfiguration(bool seedDb = true)
        {
            this.seedDb = seedDb;
        }

        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder
                .HasOne(i => i.ClothColor)
                .WithMany();

            if (seedDb)
            {
                builder
                    .HasData(CreateImages());
            }
        }

        private static List<object> CreateImages()
        {
            return new List<object>()
            {
                new
                {
                    Id = 1,
                    Url = "https://cdn.aboutstatic.com/file/images/41fb7fb9af1199c00623a77930483763.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothColorId = 2,
                    ClothId = 1
                },
                new
                {
                    Id = 2,
                    Url = "https://cdn.aboutstatic.com/file/images/079377b386685bf1b889e751cad816ee.jpg?quality=75&height=800&width=600",
                    ClothColorId = 2,
                    ClothId = 1
                },
                new
                {
                    Id = 3,
                    Url = "https://cdn.aboutstatic.com/file/images/3f9d53b537dbd3fb3228daaf51b77bf8.jpg?quality=75&height=800&width=600",
                    ClothColorId = 2,
                    ClothId = 1
                },
                new
                {
                    Id = 4,
                    Url = "https://cdn.aboutstatic.com/file/images/b1826275260cae21fb4f6a9090011bdb.jpg?quality=75&height=1280&width=960",
                    ClothColorId = 2,
                    ClothId = 1
                },
                new
                {
                    Id = 5,
                    Url = "https://cdn.aboutstatic.com/file/images/b30e9352ac137cb6270de8684c21a24d.jpg?quality=75&height=1280&width=960",
                    ClothColorId = 2,
                    ClothId = 1
                }
            };
        }
    }
}
