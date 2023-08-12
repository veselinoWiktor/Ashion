using Ashion.Infrastructure.Data.Configurations;
using Ashion.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Infrastructure.Data
{
    public class AshionDbContext : IdentityDbContext<User>
    {
        private readonly bool seedDb;

        public AshionDbContext(DbContextOptions<AshionDbContext> options, bool seedDb = true)
            : base(options)
        {
            this.seedDb = seedDb;
        }

        public DbSet<Accessory> Accessories { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Cloth> Clothes { get; set; } = null!;

        public DbSet<ClothSize> ClothesSizes { get; set; } = null!;

        public DbSet<Color> Colors { get; set; } = null!;

        public DbSet<Cosmetic> Cosmetics { get; set; } = null!;

        public DbSet<Image> Images { get; set; } = null!;

        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<Size> Sizes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (seedDb)
            {
                builder.ApplyConfiguration(new UserConfiguration());
                builder.ApplyConfiguration(new CategoryConfiguration());
                builder.ApplyConfiguration(new ColorConfiguration());
                builder.ApplyConfiguration(new SizeConfiguration());
                builder.ApplyConfiguration(new ImageConfiguration());
            }

            builder.ApplyConfiguration(new AccessoryConfiguration(seedDb));
            builder.ApplyConfiguration(new ClothConfiguration(seedDb));
            builder.ApplyConfiguration(new ClothSizeConfiguration(seedDb));
            builder.ApplyConfiguration(new CosmeticConfiguration(seedDb));
            builder.ApplyConfiguration(new ReviewConfiguration(seedDb));

            base.OnModelCreating(builder);
        }

    }
}