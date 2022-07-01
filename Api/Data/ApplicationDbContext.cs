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

            modelBuilder.Entity<ClientContactInformation<TKey>>(b =>
            {
                b.ToTable("ClientContackInformations");
                //b.HasMany(e=>e.ClientContactInformationType);
                //b.HasOne(c => c.ClientContactInformationType).WithMany(t => t.ClientContactInformations);
                //.WithMany<ClientContactInformation<TKey>>(d => d.ClientContactInformations);
                //.WithMany(a => a.ClientContactInformations);
            }
            );

            modelBuilder.Entity<ClientContactInformationType<TKey>>(b =>
            {
                b.ToTable("ClientContactInformationTypes");
                b.HasMany(e => e.ClientContactInformations).WithOne(e => e.ClientContactInformationType);
                //  .WithOne(d=>d.ClientContactInformationType);

            }
            );

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

            //Seed data\Api/Data/ApplicationDbContext.cs
            int length = 100;

            modelBuilder.Seed<TKey>(length, configuration);

        }
    }
}



