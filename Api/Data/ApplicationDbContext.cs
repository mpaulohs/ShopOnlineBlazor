using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared.Models.Catalogs;
using Shared.Models.Documents;
using Shared.Models.Identities;
using System;

namespace Api.Data
{

    public class ApplicationDbContext<TKey> : IdentityDbContext<User<TKey>, Role<TKey>, TKey, UserClaim<TKey>, UserRole<TKey>, UserLogin<TKey>, RoleClaim<TKey>, UserToken<TKey>>
where TKey : IEquatable<TKey>
    {
        private IConfiguration configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext<TKey>> options, IConfiguration configuration)
        : base(options)
        {
this.configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User<TKey>>(b =>
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

            modelBuilder.Entity<Role<TKey>>(b =>
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

            modelBuilder.Entity<UserRole<TKey>>(b => b.ToTable("UserRoles"));

            modelBuilder.Entity<UserClaim<TKey>>(b => b.ToTable("UserClaims"));

            modelBuilder.Entity<UserLogin<TKey>>(b => b.ToTable("UserLogins"));

            modelBuilder.Entity<UserToken<TKey>>(b => b.ToTable("UserTokens"));

            modelBuilder.Entity<RoleClaim<TKey>>(b => b.ToTable("RoleClaims"));

            //Catalogs

            modelBuilder.Entity<AdditionalInformation<TKey>>(b => b.ToTable("AdditionalInformations"));

            modelBuilder.Entity<Bank<TKey>>(b => b.ToTable("Banks"));

            modelBuilder.Entity<BankAccount<TKey>>(b => b.ToTable("BankAccounts"));

            modelBuilder.Entity<CashDesk<TKey>>(b => b.ToTable("CashDesks"));

            modelBuilder.Entity<ClientContactInformation<TKey>>(b => b.ToTable("ClientContackInformations"));

            modelBuilder.Entity<ClientContactInformationType<TKey>>(b => b.ToTable("ClientContactInformationTypes"));

            modelBuilder.Entity<ClientContract<TKey>>(b => b.ToTable("ClientContracts"));

            modelBuilder.Entity<Currency<TKey>>(b => b.ToTable("Currencyes"));

            modelBuilder.Entity<Product<TKey>>(b => b.ToTable("Products"));

            modelBuilder.Entity<ProductCharacteristic<TKey>>(b => b.ToTable("ProductCharacteristics"));

            modelBuilder.Entity<ProductQuality<TKey>>(b => b.ToTable("ItmeQualityes"));

            modelBuilder.Entity<ProductSerie<TKey>>(b => b.ToTable("ProductSeries"));

            modelBuilder.Entity<ProductType<TKey>>(b => b.ToTable("ProductTypes"));

            modelBuilder.Entity<ProductUnitClassifier<TKey>>(b => b.ToTable("ProductUnitClassifiers"));

            modelBuilder.Entity<ProductUnitMeasurement<TKey>>(b => b.ToTable("ProductUnitMeasuraments"));

            modelBuilder.Entity<Organization<TKey>>(b => b.ToTable("Organizations"));

            modelBuilder.Entity<Storage<TKey>>(b => b.ToTable("Storages"));

            modelBuilder.Entity<Subdivision<TKey>>(b => b.ToTable("Subdivisions"));

            //Documents

            modelBuilder.Entity<DocumentSale<TKey>>(b => b.ToTable("Documents"));

            modelBuilder.Entity<DocumentPayment<TKey>>(b => b.ToTable("Payments"));

            //modelBuilder.Entity<DocumentAdjustment<TKey>>(b => b.ToTable("Adjustments"));

            modelBuilder.Entity<Mesage<TKey>>(b => b.ToTable("Mesages"));

            //Seed data

            // int length = 100;

            // SeedDb<TKey>.Seed(modelBuilder, length, configuration);

            // int langth = 300;

            // Role[] role = new [] {
            //     //new Role()
            // };


            // for (int i = 1; i < langth; i++)
            // {
            //     var product = new Product();
            //     product.Id = Guid.NewGuid();
            //     product.FullName = Faker.Name.FullName();
            //     product.Name = Faker.
            //     product.Comment = "Cometn_" + i.ToString();
            //     product.IsPublic = true;
            //     product.Article = "Article_" + i.ToString();
            //     product.CreatedAt = DateTime.Now;
            //     product.Description = "Description_" + i.ToString();

            //     modelBuilder.Entity<Product<TKey>>().HasData(product);
            // }

        }


        //private void Seed(ModelBuilder modelBuilder)
        //{
        //    //Role
        //    string roleAdministrators = "Administrators";
        //    string roleManagers = "Managers";
        //    string roleClients = "Clients";
        //    string rolePublic = "Public";

        //    List<Role<TKey>> roles = new List<Role<TKey>>
        //    {
        //            new Role<TKey<TKey>>()
        //             {
        //                Name = roleAdministrators,
        //                NormalizedName = roleAdministrators.ToUpper(),
        //                Description = "Administrators of application"
        //            },
        //            new Role<TKey<TKey>>()
        //            {

        //                Name = roleManagers,
        //                NormalizedName = roleManagers.ToUpper(),
        //                Description = "Managers of application"
        //            },
        //            new Role<TKey<TKey>>()
        //            {

        //                Name = roleClients,
        //                NormalizedName = roleClients.ToUpper(),
        //                Description = "Clients of application"
        //            },
        //             new Role<TKey<TKey>>()
        //            {

        //                Name =rolePublic,
        //                NormalizedName = rolePublic.ToUpper(),
        //                Description = "Public users of application"
        //            }
        //    };


        //    foreach (var role in roles)
        //    {
        //        // if (this.Roles.AnyAsync<Role<TKey>>(r => r.NormalizedName == role.NormalizedName) == null)
        //        modelBuilder.Entity<Role<TKey><TKey>>().HasData(role);
        //    }


        //    //User
        //    string userAdministrator = $"Admitistrator@{Assembly.GetCallingAssembly().GetName().Name}.com";
        //    string userManager = $"Manager@{Assembly.GetCallingAssembly().GetName().Name}.com";
        //    string userClient = $"Client@{Assembly.GetCallingAssembly().GetName().Name}.com";
        //    var password = new PasswordHasher<User<TKey><TKey>>();

        //    var users = new List<User<TKey>>
        //    {
        //        new User<TKey<TKey>>()
        //        {

        //            FirstName = userAdministrator,
        //            UserName = userAdministrator,
        //            NormalizedUserName = userAdministrator.ToUpper(),
        //            Email = userAdministrator,
        //            NormalizedEmail = userAdministrator.ToUpper(),
        //            EmailConfirmed = true,
        //            SecurityStamp = DateTime.Now.ToString(),
        //            ConcurrencyStamp = DateTime.Now.ToString(),
        //            PhoneNumberConfirmed = true,
        //            TwoFactorEnabled = false,
        //            LockoutEnabled = false
        //        },
        //        new User<TKey<TKey>>()
        //        {

        //            FirstName = userManager,
        //            UserName = userManager,
        //            NormalizedUserName = userManager.ToUpper(),
        //            Email = userManager,
        //            NormalizedEmail = userManager.ToUpper(),
        //            EmailConfirmed = true,
        //            SecurityStamp = DateTime.Now.ToString(),
        //            ConcurrencyStamp = DateTime.Now.ToString(),
        //            PhoneNumberConfirmed = true,
        //            TwoFactorEnabled = false,
        //            LockoutEnabled = false
        //        },
        //        new User<TKey<TKey>>()
        //        {

        //            FirstName = userClient,
        //            UserName = userClient,
        //            NormalizedUserName = userClient.ToUpper(),
        //            Email = userClient,
        //            NormalizedEmail = userClient.ToUpper(),
        //            EmailConfirmed = true,
        //            SecurityStamp = DateTime.Now.ToString(),
        //            ConcurrencyStamp = DateTime.Now.ToString(),
        //            PhoneNumberConfirmed = true,
        //            TwoFactorEnabled = false,
        //            LockoutEnabled = false
        //        }
        //    };


        //    foreach (var user in users)
        //    {
        //        user.PasswordHash = password.HashPassword(user, "K1DvesCS");
        //        modelBuilder.Entity<User<TKey><TKey>>().HasData(user);
        //    }

        //    List<Product<TKey>> Products = new List<Product<TKey><TKey>>()
        //    {
        //        new Product<TKey<TKey>>()
        //        {

        //            Article = new Random().Next(0, 1000).ToString(),
        //            Name = "Name Product1",
        //            FullName = "Full name Product1",
        //            Description = "Description"
        //        }
        //    };


        //    List<DocumentSale<TKey>> sales = new List<DocumentSale<TKey><TKey>>()
        //    {
        //        new DocumentSale<TKey<TKey>>()
        //        {

        //            DateTime = DateTime.Now,
        //            Client = users[0],
        //            Reciver = users[0],
        //            DocumentType = DocumentType.Order,
        //            DocumentStatus = DocumentStatus.New,

        //        }
        //    };

        //    List<SaleProduct<TKey>> saleProducts = new List<SaleProduct<TKey><TKey>>()
        //    {
        //        new SaleProduct<TKey<TKey>>()
        //        {

        //            Product=Products[0],
        //            Price =  500,
        //            Discount = 10,
        //            Serie = new ProductSerie<TKey<TKey>>()
        //            {

        //                Name = "SerieForProduct"
        //            },
        //            Quality = new ProductQuality<TKey<TKey>>()
        //            {

        //                Name = "QualityForProduct"
        //            }

        //        }
        //    };

        //Curency
        //var Curensy = new HashSet<Currency<TKey>>();
        //foreach (CultureInfo Product in CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures))
        //    Curensy.Add(new Currency(Product.Name, Product.ToString(), Product.NumberFormat.CurrencySymbol));

        //foreach (Currency currency in Curensy)
        //    modelBuilder.Entity<Currency<TKey>>().HasData(currency);

    }
}

