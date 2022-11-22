using Ashion.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Data
{
    public class AshionDbContext : IdentityDbContext<User>
    {
        public AshionDbContext(DbContextOptions<AshionDbContext> options)
            : base(options)
        {
        }

        public DbSet<Accessory> Accessories { get; set; }

        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Cosmetic> Cosmetics { get; set; }
        public DbSet<Ashion.Infrastructure.Data.Models.Type> Types { get; set; }
        public DbSet<Review> Reviews { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Review>()
                .Property(p => p.Rating)
                .HasPrecision(18, 2);

            builder.Entity<Cloth>()
                .Property(p => p.Price)
                .HasPrecision(19, 4);

            builder.Entity<Accessory>()
                .Property(p => p.Price)
                .HasPrecision(19, 4);

            builder.Entity<Cosmetic>()
                .Property(p => p.Price)
                .HasPrecision(19, 4);

            base.OnModelCreating(builder);
        }
    }
}