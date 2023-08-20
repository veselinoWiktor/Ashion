using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class AccessoryConfiguration : IEntityTypeConfiguration<Accessory>
    {
        private readonly bool seedDb;

        public AccessoryConfiguration(bool seedDb = true)
        {
            this.seedDb = seedDb;
        }

        public void Configure(EntityTypeBuilder<Accessory> builder)
        {
            builder
                .HasOne(p => p.Category)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Images)
                .WithOne(i => i.Accessory)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Reviews)
                .WithOne(r => r.Accessory)
                .OnDelete(DeleteBehavior.Restrict);

            //if (seedDb)
            //{
            //    builder
            //        .HasData(CreateAccessories());
            //}
        }

        private static List<Accessory> CreateAccessories()
        {
            return new List<Accessory>();
        }
    }
}
