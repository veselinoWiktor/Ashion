using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Infrastructure.Data
{
    public class AshionDbContext : IdentityDbContext
    {
        public AshionDbContext(DbContextOptions<AshionDbContext> options)
            : base(options)
        {
        }
    }
}