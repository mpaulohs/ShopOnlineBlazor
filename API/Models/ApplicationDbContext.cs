using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Library;
using ShopOnline.Library.Models.Catalogs;
using ShopOnline.Library.Models.Documents;
using ShopOnline.Library.Models.Identities;
using ShopOnline.Library.Models.Registers;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ShopOnline.API.Models
{

    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
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

            modelBuilder.Entity<Bank>(b => b.ToTable("Banks"));

            modelBuilder.Entity<BankAccount>(b => b.ToTable("BankAccounts"));

            modelBuilder.Entity<CashDesk>(b => b.ToTable("CashDesks"));

            modelBuilder.Entity<ClientContactInformation>(b => b.ToTable("ClientContackInformations"));

            modelBuilder.Entity<ClientContactInformationType>(b => b.ToTable("ClientContactInformationTypes"));

            modelBuilder.Entity<ClientContract>(b => b.ToTable("ClientContracts"));

            modelBuilder.Entity<Currency>(b => b.ToTable("Currencyes"));

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

            modelBuilder.Entity<DocumentSale>(b => b.ToTable("Documents"));

            modelBuilder.Entity<DocumentPayment>(b => b.ToTable("Payments"));

            //modelBuilder.Entity<DocumentAdjustment>(b => b.ToTable("Adjustments"));

            modelBuilder.Entity<Mesage>(b => b.ToTable("Mesages"));

            //Seed data

            Seed(modelBuilder);
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

            var users = new List<User>
            {
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
                user.PasswordHash = password.HashPassword(user, "K1DvesCS");
                modelBuilder.Entity<User>().HasData(user);
            }

            List<Item> items = new List<Item>()
            {
                new Item()
                {
                    Id = Guid.NewGuid(),
                    Article = new Random().Next(0, 1000).ToString(),
                    Name = "Name Item1",
                    FullName = "Full name Item1",
                    Description = "Description"
                }
            };


            List<DocumentSale> sales = new List<DocumentSale>()
            {
                new DocumentSale()
                {
                    Id = Guid.NewGuid(),
                    DateTime = DateTime.Now,
                    Client = users[0],
                    Reciver = users[0],
                    DocumentType = DocumentType.Order,
                    DocumentStatus = DocumentStatus.New,

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

            //Curency
            //var Curensy = new HashSet<Currency>();
            //foreach (CultureInfo item in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
            //    Curensy.Add(new Currency(item.Name, item.ToString(), item.NumberFormat.CurrencySymbol));

            //foreach (Currency currency in Curensy)
            //    modelBuilder.Entity<Currency>().HasData(currency);

        }
    }
}
