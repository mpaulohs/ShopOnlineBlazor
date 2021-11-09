using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopOnlinePWA.Library.Catalogs;
using System.Threading.Tasks;

namespace ShopOnlinePWA.API.Migrations
{
    public static class SeedRoles
    { 

        public static async Task Run(RoleManager<Role> roleManager)
        {

            if (!roleManager.RoleExistsAsync("User").Result)
            {
                var role = new Role()
                {
                    Name = "User",
                    Description = "Default user role"
                };
                await roleManager.CreateAsync(role);
            }


            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new Role()
                {
                    Name = "Administrator",
                    Description = "System admitistrator role"
                };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
