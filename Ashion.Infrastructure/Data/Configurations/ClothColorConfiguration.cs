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
    public class ClothColorConfiguration : IEntityTypeConfiguration<ClothColor>
    {
        private readonly bool seedDb;

        public ClothColorConfiguration(bool seedDb = true)
        {
            this.seedDb = seedDb;
        }

        public void Configure(EntityTypeBuilder<ClothColor> builder)
        {
            builder.HasKey(cc => new { cc.ClothId, cc.ColorId });

            builder
                .HasOne(cc => cc.Cloth)
                .WithMany(cl => cl.Colors); 

            builder
                .HasOne(cc => cc.Color)
                .WithMany(co => co.Cloths);

            if (seedDb)
            {
                builder.HasData(CreateClothesColors());
            }
        }

        private static List<ClothColor> CreateClothesColors()
        {
            return new List<ClothColor>()
            {
                new ClothColor
                {
                    ClothId = 1,
                    ColorId = 2
                },
                new ClothColor
                {
                    ClothId = 1,
                    ColorId = 11,
                },
                new ClothColor
                {
                    ClothId = 1,
                    ColorId = 5,
                },
                new ClothColor
                {
                    ClothId = 1,
                    ColorId = 3,
                }
            };
        }
    }
}
