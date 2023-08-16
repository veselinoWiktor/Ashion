using Ashion.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Tests.Mocks
{
    public class DatabaseMock
    {
        public static AshionDbContext Instance 
        { 
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<AshionDbContext>()
                    .UseInMemoryDatabase("AshionInMemoryDb"
                        + DateTime.Now.Ticks.ToString())
                    .Options;

                return new AshionDbContext(dbContextOptions, false);
            }
        }
    }
}
