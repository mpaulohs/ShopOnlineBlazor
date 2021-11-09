using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ShopOnlinePWA.Library.Catalogs;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace ShopOnlinePWA.API.Migrations
{
    public static class SeedUsers
    {
        
        public static async Task Run(UserManager<User> userManager)
        {
            string _administrator = $"Admitistrator@{Assembly.GetCallingAssembly().GetName().Name}.com";
            string _user = $"User@{Assembly.GetCallingAssembly().GetName().Name}.com";

            if (userManager.FindByNameAsync(_administrator).Result == null)
            {
                var user = new User()
                {
                    FirstName = _administrator,
                    UserName = _administrator,
                    NormalizedUserName = _administrator.ToUpper(),
                    Email = _administrator,
                    NormalizedEmail = _administrator.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = DateTime.Now.ToString(),
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false

                };

                if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
                {
                   await userManager.AddToRoleAsync(user, "_administrator");
                }
            }

            if (userManager.FindByNameAsync(_user).Result == null)
            {
                var user = new User()
                {
                    FirstName = _user,
                    UserName = _user,
                    NormalizedUserName = _user.ToUpper(),
                    Email = _user,
                    NormalizedEmail = _user.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = DateTime.Now.ToString(),
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false

                };

                if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
                {
                   await userManager.AddToRoleAsync(user, "User");
                }
            }
        }
    }
}
