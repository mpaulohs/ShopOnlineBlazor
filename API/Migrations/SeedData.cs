using Microsoft.AspNetCore.Identity;
using ShopOnlinePWA.Library.Identity;
using System.Threading.Tasks;

namespace ShopOnlinePWA.API.Migrations.AppIdentityDb
{
    public static class SeedData
    {
        public static async Task Run(RoleManager<Role> roleManager, UserManager<User> userManager)
        {
            await SeedRoles.Run(roleManager);
            await SeedUsers.Run(userManager);
        }

    }
}
