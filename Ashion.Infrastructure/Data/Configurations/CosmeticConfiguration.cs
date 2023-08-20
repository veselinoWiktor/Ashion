using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class CosmeticConfiguration : IEntityTypeConfiguration<Cosmetic>
    {
        private readonly bool seedDb;

        public CosmeticConfiguration(bool seedDb = true)
        {
            this.seedDb = seedDb; 
        }

        public void Configure(EntityTypeBuilder<Cosmetic> builder)
        {
            builder
                .HasOne(p => p.Category)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Images)
                .WithOne(i => i.Cosmetic)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Reviews)
                .WithOne(r => r.Cosmetic)
                .OnDelete(DeleteBehavior.Restrict);

            //if (seedDb)
            //{
            //    builder
            //        .HasData(CreateCosmetics());
            //}
        }

        private static List<Cosmetic> CreateCosmetics()
        {
            throw new NotImplementedException();
        }
    }
}
