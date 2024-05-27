using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SIPKK.Models;
using System;
using System.Collections.Generic;
using Visus.Cuid;

namespace SIPKK.DataAccess.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<string>>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string[] roleNames = { "Admin", "Mahasiswa", "Dosen" };
            IdentityResult roleResult;

            foreach(var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);

                if(!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            var adminUser = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@gmail.com"
            };

            string adminPassword = "123456789";
            var user = await userManager.FindByEmailAsync(adminUser.Email);

            if(user == null)
            {
                var createAdminUser = await userManager.CreateAsync(adminUser, adminPassword);
                if(createAdminUser.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
