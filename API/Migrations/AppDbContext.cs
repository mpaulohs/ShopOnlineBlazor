using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopOnlinePWA.Library.Documents;
using ShopOnlinePWA.Library.Identity;
using System;
using System.Collections.Generic;
using System.Reflection;

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

            this.Seed(modelBuilder);
        }


        private void Seed(ModelBuilder modelBuilder)
        {
            //Seed data

            //Role
            string roleAdministrators = "Administrators";
            string roleManagers = "Managers";
            string roleClients = "Clients";
            string rolePublic = "Public";

            List<Role> roles = new List<Role> {
                    new Role()
                     {
                        Id = Guid.NewGuid(),
                        Name = roleAdministrators,
                        NormalizedName = roleAdministrators.ToUpper(),
                        Description = "Administrators of application"
                    },
                    new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = roleManagers,
                        NormalizedName = roleManagers.ToUpper(),
                        Description = "Managers of application"
                    },               
                    new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = roleClients,
                        NormalizedName = roleClients.ToUpper(),
                        Description = "Clients of application"
                    },
                     new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name =rolePublic,
                        NormalizedName = rolePublic.ToUpper(),
                        Description = "Public users of application"
                    }
            };


            foreach (var role in roles)
            {
                // if (this.Roles.AnyAsync<Role>(r => r.NormalizedName == role.NormalizedName) == null)
                modelBuilder.Entity<Role>().HasData(role);
            }


            //User
            string userAdministrator = $"Admitistrator@{Assembly.GetCallingAssembly().GetName().Name}.com";
            string userManager = $"Manager@{Assembly.GetCallingAssembly().GetName().Name}.com";
            string userClient = $"Client@{Assembly.GetCallingAssembly().GetName().Name}.com";
            var password = new PasswordHasher<User>();

            var users = new List<User> {
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = userAdministrator,
                    UserName = userAdministrator,
                    NormalizedUserName = userAdministrator.ToUpper(),
                    Email = userAdministrator,
                    NormalizedEmail = userAdministrator.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = DateTime.Now.ToString(),
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = userManager,
                    UserName = userManager,
                    NormalizedUserName = userManager.ToUpper(),
                    Email = userManager,
                    NormalizedEmail = userManager.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = DateTime.Now.ToString(),
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = userClient,
                    UserName = userClient,
                    NormalizedUserName = userClient.ToUpper(),
                    Email = userClient,
                    NormalizedEmail = userClient.ToUpper(),
                    EmailConfirmed = true,
                    SecurityStamp = DateTime.Now.ToString(),
                    ConcurrencyStamp = DateTime.Now.ToString(),
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false
                }
            };

          
            foreach (var user in users)
            {
                // if (this.Roles.AnyAsync<Role>(r => r.NormalizedName == role.NormalizedName) == null)
                user.PasswordHash = password.HashPassword(user, "K1DvesCS");
                modelBuilder.Entity<User>().HasData(user);

                //if (user.NormalizedUserName == userAdministrator.ToUpper())
                //{
                //    var role = roles.Find(r => r.NormalizedName == roleAdministrators.ToUpper());
                //    if (role != null)
                //        modelBuilder.Entity<UserRole>().HasData(new RoleClaim()
                //        {
                //            Role = role,
                //            RoleId = role.Id,
                //            ClaimValue = user.Id.ToString(),          
                //        }) ;
        
                //}

            }
        }
    }
}
