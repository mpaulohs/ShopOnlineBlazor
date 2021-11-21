using Microsoft.AspNetCore.Identity;
using ShopOnlinePWA.Library.Identity;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ShopOnlinePWA.API.Migrations
{
    public class SeedData
    {

        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly AppDbContext context;

        public SeedData(AppDbContext context, UserManager<User> userManager, RoleManager<Role> roleManager)

        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        public void Seed()
        {


            //Seed data
            //Role
            if (roleManager.FindByNameAsync("Administrators") == null)
            {
                var role = new Role()
                {
                    Id = new Guid(),
                    Name = "Administrators",
                    Description = "Administrators of application"
                };

                roleManager.UpdateAsync(role);
            }

            if (roleManager.FindByNameAsync("Managers") == null)
            {
                var role = new Role()
                {
                    Id = new Guid(),
                    Name = "Managers",
                    Description = "Managers of application"
                };

                roleManager.UpdateAsync(role);
            }

            if (roleManager.FindByNameAsync("Clients") == null)
            {
                var role = new Role()
                {
                    Id = new Guid(),
                    Name = "Clients",
                    Description = "Clients of application"
                };

                roleManager.UpdateAsync(role);
            }


            if (roleManager.FindByNameAsync("Public") == null)
            {
                var role = new Role()
                {
                    Id = new Guid(),
                    Name = "Public",
                    Description = "Public users of application"
                };

                roleManager.UpdateAsync(role);
            }

            //User
            string _administrator = $"Admitistrator@{Assembly.GetCallingAssembly().GetName().Name}.com";
            string _manager = $"Manager@{Assembly.GetCallingAssembly().GetName().Name}.com";
            string _user = $"Client@{Assembly.GetCallingAssembly().GetName().Name}.com";

            if (!roleManager.RoleExistsAsync(_administrator).Result)
            {
                var user = new User()
                {
                    Id = new Guid(),
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

                context.Users.Add(user);

                if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
                {
                    userManager.AddToRoleAsync(user, "Administrators");
                };

            };



            if (!roleManager.RoleExistsAsync(_manager).Result)
            {
                var user = new User()
                {
                    Id = new Guid(),
                    FirstName = _manager,
                    UserName = _manager,
                    NormalizedUserName = _manager.ToUpper(),
                    Email = _manager,
                    NormalizedEmail = _manager.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = DateTime.Now.ToString(),
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false
                };

                context.Users.Add(user);

                if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
                {
                    userManager.AddToRoleAsync(user, "Managers");
                };
            };

            if (!roleManager.RoleExistsAsync(_user).Result)
            {
                var user = new User()
                {
                    Id = new Guid(),
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

                context.Users.Add(user);

                if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
                {
                    userManager.AddToRoleAsync(user, "Clients");
                };
            };
        }
    }
}

