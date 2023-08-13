using Ashion.Core.Contracts;
using Ashion.Core.Services;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AshionApiSerivceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ILikesService, LikesService>();

            return services;
        }

        public static IServiceCollection AddAshionDbContext(this IServiceCollection services, IConfiguration configuration) 
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AshionDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
