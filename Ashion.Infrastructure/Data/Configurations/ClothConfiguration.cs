using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Ashion.Infrastructure.Data.Configurations.ColorConfiguration;
using static Ashion.Infrastructure.Data.Configurations.SizeConfiguration;

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
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Reviews)
                .WithOne()
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
                    Name = "Tениска",
                    Brand = "Nike",
                    Price = 58.90m,
                    Description = "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.",
                    Quantity = 10,
                    CategoryId = 1,
                    ForKids = false,
                    Gender = Gender.Male,
                }
            };
        }
    }
}
