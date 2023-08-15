using Ashion.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private static List<User> CreateUsers()
        {
            var users = new List<User>();

            var hasher = new PasswordHasher<User>();

            var admin = new User()
            {
                Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                FirstName = "Great",
                LastName = "Admin"
            };

            admin.PasswordHash = hasher.HashPassword(admin, "admin123");
            users.Add(admin);

            return users;
        }
    }
}
