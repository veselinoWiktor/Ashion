﻿using Ashion.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using static Ashion.Web.Areas.Admin.AdminConstants;

namespace Ashion.Web.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(AdminRoleName))
                {
                    return;
                }
                var role = new IdentityRole { Name = AdminRoleName };

                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByNameAsync(AdminEmail);

                await userManager.AddToRoleAsync(admin, role.Name);
            })
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}
