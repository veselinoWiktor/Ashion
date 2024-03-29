﻿using Ashion.Core.Contracts;
using Ashion.Core.Services;
using Ashion.Infrastructure.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AshionServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IShopService, ShopService>();
            services.AddScoped<IClothService, ClothService>();
            services.AddScoped<IAccessoriesService, AccessoriesService>();
            services.AddScoped<ICosmeticsService, CosmeticsService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
