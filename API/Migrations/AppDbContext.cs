﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopOnlinePWA.Library.Catalogs;
using ShopOnlinePWA.Library.Documents;
using ShopOnlinePWA.Library.Identity;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ShopOnlinePWA.API.Migrations
{

    public class AppDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
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

            //Catalogs

            modelBuilder.Entity<AdditionalInformation>(b => b.ToTable("AdditionalInformations"));

            modelBuilder.Entity<AdditionalInformationType>(b => b.ToTable("AddititonalInformationTypes"));

            modelBuilder.Entity<Bank>(b => b.ToTable("Banks"));

            modelBuilder.Entity<BankAccount>(b => b.ToTable("BankAccounts"));

            modelBuilder.Entity<CashDesk>(b => b.ToTable("CashDesks"));

            modelBuilder.Entity<ClientContactInformation>(b => b.ToTable("ClientContackInformations"));

            modelBuilder.Entity<ClientContactInformationType>(b => b.ToTable("ClientContactInformationTypes"));

            modelBuilder.Entity<ClientContract>(b => b.ToTable("ClientContracts"));

            modelBuilder.Entity<Currency>(b => b.ToTable("Currencyes"));

            modelBuilder.Entity<DocumentStatus>(b => b.ToTable("DocumentStatuses"));

            modelBuilder.Entity<Item>(b => b.ToTable("Items"));

            modelBuilder.Entity<ItemCharacteristic>(b => b.ToTable("ItemCharacteristics"));

            modelBuilder.Entity<ItemQuality>(b => b.ToTable("ItmeQualityes"));

            modelBuilder.Entity<ItemSerie>(b => b.ToTable("ItemSeries"));

            modelBuilder.Entity<ItemType>(b => b.ToTable("ItemTypes"));

            modelBuilder.Entity<ItemUnitClassifier>(b => b.ToTable("ItemUnitClassifiers"));

            modelBuilder.Entity<ItemUnitMeasurement>(b => b.ToTable("ItemUnitMeasuraments"));

            modelBuilder.Entity<Organization>(b => b.ToTable("Organizations"));

            modelBuilder.Entity<Storage>(b => b.ToTable("Storages"));

            modelBuilder.Entity<Subdivision>(b => b.ToTable("Subdivisions"));

            //Documents

            modelBuilder.Entity<Sale>(b => b.ToTable("Sales"));

            modelBuilder.Entity<Payment>(b => b.ToTable("Payments"));

            modelBuilder.Entity<Adjustment>(b => b.ToTable("Adjustments"));

            modelBuilder.Entity<Mesage>(b => b.ToTable("Mesages"));

            //Seed data

            this.Seed(modelBuilder);
        }


        private void Seed(ModelBuilder modelBuilder)
        {
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

            List<Item> items = new List<Item>() {
                new Item()
                {
                    Id = Guid.NewGuid(),
                    Article = new Random().Next(0, 1000).ToString(),
                    Name = "Name Item1",
                    FullName = "Full name Item1",
                    Description = "Description"
                }
            };


            List<Sale> sales = new List<Sale>()
            {
                new Sale()
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now,
                    Client = users[0],
                    Reciver = users[0],
                }
            };

            List<SaleItem> saleItems = new List<SaleItem>()
            {
                new SaleItem()
                {
                    Id= Guid.NewGuid(),
                    Item=items[0],
                    Price =  500,
                    Discount = 10,
                    Serie = new ItemSerie()
                    {
                        Id = Guid.NewGuid(),
                        Name = "SerieForItem"
                    },
                    Quality = new ItemQuality()
                    {
                        Id = Guid.NewGuid(),
                        Name = "QualityForItem"
                    }
                    
                }
            };
        }
    }
}