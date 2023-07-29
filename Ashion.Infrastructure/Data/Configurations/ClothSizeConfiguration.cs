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
    public class ClothSizeConfiguration : IEntityTypeConfiguration<ClothSize>
    {
        private readonly bool seedDb;

        public ClothSizeConfiguration(bool seedDb = true)
        {
            this.seedDb = seedDb;
        }

        public void Configure(EntityTypeBuilder<ClothSize> builder)
        {
            builder.HasKey(cs => new { cs.ClothId, cs.SizeId });

            builder
                .HasOne(cs => cs.Cloth)
                .WithMany(c => c.Sizes);

            builder
                .HasOne(cs => cs.Size)
                .WithMany(s => s.Cloths);

            if (seedDb)
            {
                builder.HasData(CreateClothesSizes());
            }
        }

        private static List<ClothSize> CreateClothesSizes()
        {
            return new List<ClothSize>()
            {
                //First T-Shirt
                new ClothSize()
                {
                    ClothId = 1,
                    SizeId = 2
                },
                new ClothSize()
                {
                    ClothId = 1,
                    SizeId = 3
                },
                new ClothSize()
                {
                    ClothId = 1,
                    SizeId = 4
                },
                new ClothSize()
                {
                    ClothId = 1,
                    SizeId = 5
                },
                //Second T-Shirt
                new ClothSize()
                {
                    ClothId = 2,
                    SizeId = 2
                },
                new ClothSize()
                {
                    ClothId = 2,
                    SizeId = 3
                },
                new ClothSize()
                {
                    ClothId = 2,
                    SizeId = 4
                },
                new ClothSize()
                {
                    ClothId = 2,
                    SizeId = 5
                },
                new ClothSize()
                {
                    ClothId = 2,
                    SizeId = 6
                }
            };
        }
    }
}
