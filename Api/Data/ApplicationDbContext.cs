using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared.Models.Catalogs;
using Shared.Models.Documents;
using Shared.Models.Identities;
using System;
using System.Collections.Generic;

namespace Api.Data
{

    public class ApplicationDbContext<TKey> : IdentityDbContext<User<TKey>, Role<TKey>, TKey, UserClaim<TKey>, UserRole<TKey>, UserLogin<TKey>, RoleClaim<TKey>, UserToken<TKey>> where TKey : IEquatable<TKey>
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


            //Identityes

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

            modelBuilder.Entity<BankAccount<TKey>>(e =>
                       {
                           e.ToTable("BankAccounts");
                           e.HasOne(e => e.Bank).WithMany(e => e.BankAccounts);
                       });

            modelBuilder.Entity<CashDesk<TKey>>(b => b.ToTable("CashDesks"));

            modelBuilder.Entity<ClientContactInformationType<TKey>>().ToTable("ClientContactInformationTypes");

            modelBuilder.Entity<ClientContactInformation<TKey>>().ToTable("ClientContackInformations");

            modelBuilder.Entity<ClientContract<TKey>>(b =>
            {
                b.ToTable("ClientContracts");
                b.HasOne(e => e.Client);
                b.HasOne(e => e.Currency);
            });

            modelBuilder.Entity<Currency<TKey>>(b => b.ToTable("Currencyes"));

            modelBuilder.Entity<ProductCharacteristic<TKey>>(b => b.ToTable("ProductCharacteristics"));

            modelBuilder.Entity<ProductQuality<TKey>>(b => b.ToTable("ProductQualityes"));

            modelBuilder.Entity<ProductQuantity<TKey>>(b => b.ToTable("ProductQuantityes"));

            modelBuilder.Entity<Product<TKey>>(e =>
                            {
                                e.ToTable("Products");
                                e.HasMany(e => e.ProductCharacteristics).WithMany(e => e.Products);
                                e.HasOne(e => e.ProductQuality);
                                e.HasOne(e => e.ProductSerie);
                                e.HasOne(e => e.ProductType);
                                e.HasOne(e => e.ProductUnitMeasurement);
                            }
            );


            modelBuilder.Entity<ProductSerie<TKey>>(b => b.ToTable("ProductSeries"));

            modelBuilder.Entity<ProductType<TKey>>(b => b.ToTable("ProductTypes"));

            modelBuilder.Entity<ProductUnitClassifier<TKey>>(b => b.ToTable("ProductUnitClassifiers"));

            modelBuilder.Entity<ProductUnitMeasurement<TKey>>(b => b.ToTable("ProductUnitMeasuraments"));

            modelBuilder.Entity<PriceType<TKey>>(b => b.ToTable("PriceTypes"));

            modelBuilder.Entity<Organization<TKey>>(b => b.ToTable("Organizations"));

            modelBuilder.Entity<Storage<TKey>>(b => b.ToTable("Storages"));

            modelBuilder.Entity<Subdivision<TKey>>(b => b.ToTable("Subdivisions"));

            //Documents

            modelBuilder.Entity<DocumentStatus<TKey>>().ToTable("DocumentStatuses");

            modelBuilder.Entity<DocumentType<TKey>>().ToTable("DocumentTypes");

            modelBuilder.Entity<DocumentSale<TKey>>(b => b.ToTable("Documents"));

            modelBuilder.Entity<DocumentPayment<TKey>>(b => b.ToTable("Payments"));

            //modelBuilder.Entity<DocumentAdjustment<TKey>>(b => b.ToTable("Adjustments"));

            modelBuilder.Entity<Mesage<TKey>>(b => b.ToTable("Mesages"));

            int length = 100;

            modelBuilder.Seed<TKey>(length, configuration);

        }
    }
}



