using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private static List<Category> CreateCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "T-Shirts",
                    ProductType = ProductType.Cloth
                },
                new Category()
                {
                    Id = 2,
                    Name = "Jeans",
                    ProductType = ProductType.Cloth
                },
                new Category()
                {
                    Id = 3,
                    Name = "Pants",
                    ProductType = ProductType.Cloth
                },
                new Category()
                {
                    Id = 4,
                    Name = "Sweatshirts",
                    ProductType = ProductType.Cloth
                },
                new Category()
                {
                    Id = 5,
                    Name = "Jackets",
                    ProductType = ProductType.Cloth
                },
                new Category()
                {
                    Id = 6,
                    Name = "Shirts",
                    ProductType = ProductType.Cloth
                },
                new Category()
                {
                    Id = 7,
                    Name = "BagsandBackpacks",
                    ProductType = ProductType.Accessory
                },
                new Category()
                {
                    Id = 8,
                    Name = "Sunglasses",
                    ProductType = ProductType.Accessory
                },
                new Category()
                {
                    Id = 9,
                    Name = "Jewelries",
                    ProductType = ProductType.Accessory
                },
                new Category()
                {
                    Id = 10,
                    Name = "Antiagecosmetic",
                    ProductType = ProductType.Cosmetics,
                },
                new Category()
                {
                    Id = 11,
                    Name = "Facecosmetic",
                    ProductType = ProductType.Cosmetics
                },
                new Category()
                {
                    Id = 12,
                    Name = "SPF",
                    ProductType = ProductType.Cosmetics
                }
            };
        }
    }
}
