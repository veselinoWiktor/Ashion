using Ashion.Infrastructure.Data.Configurations;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Infrastructure.Data
{
    public class AshionDbContext : IdentityDbContext
    {
        private bool seedDb;

        public AshionDbContext(DbContextOptions<AshionDbContext> options, bool seedDb = true)
            : base(options)
        {
            this.seedDb = seedDb;
        }

        public DbSet<Accessory> Accessories { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Cloth> Clothes { get; set; } = null!;

        public DbSet<ClothSize> ClothesSizes { get; set; } = null!;

        public DbSet<ClothColor> ClothesColors { get; set; } = null!;

        public DbSet<Color> Colors { get; set; } = null!;

        public DbSet<Cosmetic> Cosmetics { get; set; } = null!;

        public DbSet<Image> Images { get; set; } = null!;

        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<Size> Sizes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AccessoryConfiguration(seedDb));

            builder
                .Entity<Cloth>()
                .HasOne(p => p.Category)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Cloth>()
                .HasMany(p => p.Images)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Cloth>()
                .HasMany(p => p.Reviews)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Cosmetic>()
                .HasOne(p => p.Category)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Cosmetic>()
                .HasMany(p => p.Images)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Cosmetic>()
                .HasMany(p => p.Reviews)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Review>()
                .HasOne(r => r.FromUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ClothColor>()
                .HasKey(cc => new { cc.ClothId, cc.ColorId });

            builder.Entity<ClothColor>()
                .HasOne(cc => cc.Cloth)
                .WithMany(cl => cl.Colors)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<ClothColor>()
                .HasOne(cc => cc.Color)
                .WithMany(co => co.Cloths)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ClothSize>()
                .HasKey(cs => new { cs.ClothId, cs.SizeId });

            builder.Entity<ClothSize>()
               .HasOne(cs => cs.Cloth)
               .WithMany(co => co.Sizes)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ClothSize>()
                .HasOne(cs => cs.Size)
                .WithMany(co => co.Cloths)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }

    }
}