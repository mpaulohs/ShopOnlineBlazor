using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopOnlinePWA.Library.Documents;
using ShopOnlinePWA.Library.Identity;
using System;

namespace ShopOnlinePWA.API.Migrations
{

    public class AppDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        //private readonly UserManager<User> userManager;
        //private readonly RoleManager<Role> roleManager;

        //public AppDbContext(DbContextOptions<AppDbContext> options, UserManager<User> userManager, RoleManager<Role> roleManager)
        //: base(options)
        //{
        //    this.userManager = userManager;
        //    this.roleManager = roleManager;
        //}
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(b =>
            {
                // Table name
                b.ToTable("Users");

                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<Role>(b =>
            {
                // Table name
                b.ToTable("Roles");

                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });

            modelBuilder.Entity<UserRole>(b => b.ToTable("UserRoles"));

            modelBuilder.Entity<UserClaim>(b => b.ToTable("UserClaims"));

            modelBuilder.Entity<UserLogin>(b => b.ToTable("UserLogins"));

            modelBuilder.Entity<UserToken>(b => b.ToTable("UserTokens"));

            modelBuilder.Entity<RoleClaim>(b => b.ToTable("RoleClaims"));

            modelBuilder.Entity<Order>(b => b.ToTable("Orders"));

            this.SeedRoles(modelBuilder);

            //{
            //    //Seed data
            //    //Role
            //    if (roleManager.FindByNameAsync("Administrators") == null)
            //    {
            //        var role = new Role()
            //        {
            //            Id = new Guid(),
            //            Name = "Administrators",
            //            Description = "Administrators of application"
            //        };

            //        roleManager.UpdateAsync(role);
            //    }

            //    if (roleManager.FindByNameAsync("Managers") == null)
            //    {
            //        var role = new Role()
            //        {
            //            Id = new Guid(),
            //            Name = "Managers",
            //            Description = "Managers of application"
            //        };

            //        roleManager.UpdateAsync(role);
            //    }

            //    if (roleManager.FindByNameAsync("Clients") == null)
            //    {
            //        var role = new Role()
            //        {
            //            Id = new Guid(),
            //            Name = "Clients",
            //            Description = "Clients of application"
            //        };

            //        roleManager.UpdateAsync(role);
            //    }


            //    if (roleManager.FindByNameAsync("Public") == null)
            //    {
            //        var role = new Role()
            //        {
            //            Id = new Guid(),
            //            Name = "Public",
            //            Description = "Public users of application"
            //        };

            //        roleManager.UpdateAsync(role);
            //    }

            //    //User
            //    string _administrator = $"Admitistrator@{Assembly.GetCallingAssembly().GetName().Name}.com";
            //    string _manager = $"Manager@{Assembly.GetCallingAssembly().GetName().Name}.com";
            //    string _user = $"Client@{Assembly.GetCallingAssembly().GetName().Name}.com";

            //    List<User> users = null;

            //    if (!roleManager.RoleExistsAsync(_administrator).Result)
            //    {
            //        var user = new User()
            //        {
            //            Id = new Guid(),
            //            FirstName = _administrator,
            //            UserName = _administrator,
            //            NormalizedUserName = _administrator.ToUpper(),
            //            Email = _administrator,
            //            NormalizedEmail = _administrator.ToUpper(),
            //            EmailConfirmed = true,
            //            SecurityStamp = DateTime.Now.ToString(),
            //            ConcurrencyStamp = DateTime.Now.ToString(),
            //            PhoneNumberConfirmed = true,
            //            TwoFactorEnabled = false,
            //            LockoutEnabled = false
            //        };

            //        users.Add(user);

            //        modelBuilder.Entity<User>().HasData(users);

            //        if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
            //        {
            //            userManager.AddToRoleAsync(user, "Administrators");
            //        };

            //    };



            //    if (!roleManager.RoleExistsAsync(_manager).Result)
            //    {
            //        var user = new User()
            //        {
            //            Id = new Guid(),
            //            FirstName = _manager,
            //            UserName = _manager,
            //            NormalizedUserName = _manager.ToUpper(),
            //            Email = _manager,
            //            NormalizedEmail = _manager.ToUpper(),
            //            EmailConfirmed = true,
            //            SecurityStamp = DateTime.Now.ToString(),
            //            ConcurrencyStamp = DateTime.Now.ToString(),
            //            PhoneNumberConfirmed = true,
            //            TwoFactorEnabled = false,
            //            LockoutEnabled = false
            //        };

            //        users.Add(user);

            //        modelBuilder.Entity<User>().HasData(users);

            //        if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
            //        {
            //            userManager.AddToRoleAsync(user, "Managers");
            //        };
            //    };

            //    if (!roleManager.RoleExistsAsync(_user).Result)
            //    {
            //        var user = new User()
            //        {
            //            Id = new Guid(),
            //            FirstName = _user,
            //            UserName = _user,
            //            NormalizedUserName = _user.ToUpper(),
            //            Email = _user,
            //            NormalizedEmail = _user.ToUpper(),
            //            EmailConfirmed = true,
            //            SecurityStamp = DateTime.Now.ToString(),
            //            ConcurrencyStamp = DateTime.Now.ToString(),
            //            PhoneNumberConfirmed = true,
            //            TwoFactorEnabled = false,
            //            LockoutEnabled = false
            //        };

            //        users.Add(user);

            //        modelBuilder.Entity<User>().HasData(users);

            //        if (userManager.CreateAsync(user, "Password@1234").Result == IdentityResult.Success)
            //        {
            //            userManager.AddToRoleAsync(user, "Clients");
            //        };
            //    };
            //}
        }


        private void SeedRoles(ModelBuilder modelBuilder)
        {
            //Seed data
            //Role

            Role[] roles = {
                    new Role()
                     {
                    Id = Guid.NewGuid(),
                    Name = "Administrators",
                    Description = "Administrators of application"
                     },
                    new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Managers",
                        Description = "Managers of application"
                    },
                     new Role()
                     {
                    Id = Guid.NewGuid(),
                    Name = "Public",
                    Description = "Public users of application"
                        },
                 new Role()
                   {
                    Id = Guid.NewGuid(),
                    Name = "Clients",
                    Description = "Clients of application"
                    }
            };


            foreach (var role in roles)
            {
                // if (this.Roles.AnyAsync<Role>(r => r.Name == "Managers") == null)
                modelBuilder.Entity<Role>().HasData(role);
            }
        }
    }
}
