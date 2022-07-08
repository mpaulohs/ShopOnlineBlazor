using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using Bogus;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Shared.Models.Catalogs;
using Shared.Models.Identities;

namespace Api.Data
{
    public static class ModelBuilderExtensions

    {
        public static void Seed<TKey>(this ModelBuilder modelBuilder, int length, IConfiguration configuration) where TKey : IEquatable<TKey>
        {

            Debugger.Launch();
            System.Console.WriteLine("Start");
            if (System.Diagnostics.Debugger.IsAttached == false)
            {
                var res = System.Diagnostics.Debugger.Launch();
                System.Console.WriteLine("Debugger lunched: " + res.ToString());
            }

            var faker = new Faker();
            int counter = 0;

            //Catalogs

            var banks = new List<Bank<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Bank<TKey>();

                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    Guid Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }

                entity.Name = "Bank " + faker.Company.CompanyName();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                banks.Add(entity);
            }

            var bankAccounts = new List<dynamic>();
            for (int i = 0; i < length; i++)
            {
                counter++;
                var CreatedAt = faker.Date.Past(5);

                var entity = new
                {
                    Id = (typeof(TKey) == typeof(Guid)) ? Guid.NewGuid().ChangeType<TKey>() : (TKey)Convert.ChangeType(counter, typeof(TKey)),

                    Name = "Bank account: " + faker.Lorem.Word(),
                    BankId = faker.PickRandom(banks).Id,
                    CreatedAt = CreatedAt,
                    UpdatedAt = faker.Date.Between(CreatedAt, DateTime.Now),
                    Comment = faker.Lorem.Sentence(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                };
                bankAccounts.Add(entity);
            }

            var cashDescks = new List<CashDesk<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new CashDesk<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Cash desk: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                cashDescks.Add(entity);
            }

            var clientContactInformatinTypeName = configuration.GetSection("Catalogs:ClientContactInformationType").Get<List<string>>();
            var clientContactInformationTypes = new List<ClientContactInformationType<TKey>>();
            for (int i = 0; i < clientContactInformatinTypeName.Count; i++)
            {
                var entity = new ClientContactInformationType<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = clientContactInformatinTypeName[i];
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                clientContactInformationTypes.Add(entity);
            }

            var clientContactInformatinModel = new List<dynamic>();
            for (int i = 0; i < length; i++)
            {
                var CreatedAt = faker.Date.Past(5);
                var entity = new
                {
                    Id = (typeof(TKey) == typeof(Guid)) ? Guid.NewGuid().ChangeType<TKey>() : (TKey)Convert.ChangeType(counter, typeof(TKey)),
                    Name = faker.Address.FullAddress(),
                    CreatedAt = CreatedAt,
                    UpdatedAt = faker.Date.Between(CreatedAt, DateTime.Now),
                    Comment = faker.Lorem.Sentence(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    ClientContactInformationTypeId = faker.PickRandom<ClientContactInformationType<TKey>>(clientContactInformationTypes).Id
                };
                clientContactInformatinModel.Add(entity);
            };

            var currencies = configuration.GetSection("Catalogs:Currency").Get<List<Currency<TKey>>>();
            for (int i = 0; i < currencies.Count; i++)
            {
                var entity = currencies[i];
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
            }

            var documentStatusNames = configuration.GetSection("Catalogs:DocumentStatus").Get<List<string>>();
            var documentStatuses = new List<DocumentStatus<TKey>>();
            for (int i = 0; i < documentStatusNames.Count; i++)
            {
                var entity = new DocumentStatus<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = documentStatusNames[i];
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                documentStatuses.Add(entity);
            }

            var documentTypeNames = configuration.GetSection("Catalogs:DocumentStatus").Get<List<string>>();
            var documentTypes = new List<DocumentType<TKey>>();
            for (int i = 0; i < documentTypeNames.Count; i++)
            {
                var entity = new DocumentType<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = documentTypeNames[i];
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                documentTypes.Add(entity);
            }

            var organizations = new List<Organization<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Organization<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Organization " + faker.Company.CompanyName();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                organizations.Add(entity);
            }


            var priceTypeNames = configuration.GetSection("Catalogs:PriceType").Get<List<string>>();
            var priceTypes = new List<PriceType<TKey>>();
            for (int i = 0; i < priceTypeNames.Count; i++)
            {
                var entity = new PriceType<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = priceTypeNames[i];
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                priceTypes.Add(entity);
            }

            var productCharacteristics = new List<ProductCharacteristic<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductCharacteristic<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = faker.Commerce.Color();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productCharacteristics.Add(entity);
            }

            var productQuality = new List<ProductQuality<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductQuality<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Product quaity: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productQuality.Add(entity);
            }

            var productQuantityes = new List<ProductQuantity<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductQuantity<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Product quanity: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productQuantityes.Add(entity);
            }

            var productSeries = new List<ProductSerie<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductSerie<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Product serie: " + faker.Commerce.Ean13();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productSeries.Add(entity);
            }

            var productTypes = new List<ProductType<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductType<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Product type: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productTypes.Add(entity);
            }

            var productUnitClassifiers = new List<ProductUnitClassifier<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductUnitClassifier<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Product unit classifier: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productUnitClassifiers.Add(entity);
            }

            var productUnitMeasurements = new List<ProductUnitMeasurement<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductUnitMeasurement<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Product unit measurement: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productUnitMeasurements.Add(entity);
            }

            var storages = new List<Storage<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Storage<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Storage: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                storages.Add(entity);
            }

            var subdivisions = new List<Subdivision<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Subdivision<TKey>();
                counter++;
                if (typeof(TKey) == typeof(Guid))
                {
                    var Id = Guid.NewGuid();
                    entity.Id = Id.ChangeType<TKey>();
                }
                else
                {
                    entity.Id = (TKey)Convert.ChangeType(counter, typeof(TKey));
                }
                entity.Name = "Subdivision: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                subdivisions.Add(entity);
            }

            var products = new List<Object>();
            for (int i = 1; i < length; i++)
            {
                var CreatedAt = faker.Date.Past(5);

                var entity = new
                {
                    Id = (typeof(TKey) == typeof(Guid)) ? Guid.NewGuid().ChangeType<TKey>() : (TKey)Convert.ChangeType(counter, typeof(TKey)),
                    Name = "Bank account: " + faker.Lorem.Word(),
                    FullName = faker.Commerce.Product(),
                    CreatedAt = CreatedAt,
                    UpdatedAt = faker.Date.Between(CreatedAt, DateTime.Now),
                    Comment = faker.Lorem.Sentence(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    IsPublic = faker.Random.Bool(),
                    Article = faker.Commerce.Ean13(),
                    Description = faker.Commerce.ProductDescription(),
                    MainImageUrl = faker.Image.Random.ToString(),
                    //ToDo ProductCharacteristics = productCharacteristics,
                    ProductQualityId = faker.PickRandom<ProductQuality<TKey>>(productQuality).Id,
                    ProductSerieId = faker.PickRandom<ProductSerie<TKey>>(productSeries).Id,
                    ProductTypeId = faker.PickRandom<ProductType<TKey>>(productTypes).Id,
                    ProductUnitMeasurementId = faker.PickRandom<ProductUnitMeasurement<TKey>>(productUnitMeasurements).Id,
                };
                products.Add(entity);
            }

            var users = new List<User<TKey>>();
            for (int i = 1; i < length; i++)
            {
                var person = new Bogus.Person();
                var CreatedAt = faker.Date.Past(5);

                var entity = new User<TKey>();
                entity.Id = (typeof(TKey) == typeof(Guid)) ? Guid.NewGuid().ChangeType<TKey>() : (TKey)Convert.ChangeType(counter, typeof(TKey));
                entity.ExchangeId = Guid.NewGuid().ToString();
                entity.FirstName = person.FirstName;
                entity.MiddleName = person.LastName;
                entity.LastName = person.LastName;
                entity.UserName = person.UserName;
                entity.NormalizedUserName = entity.UserName.Trim().ToUpper().Normalize();
                entity.UpdatedAt = faker.Date.Between(CreatedAt, DateTime.Now);
                entity.Email = person.Email;
                entity.NormalizedEmail = entity.Email.Trim().ToUpper().Normalize();
                entity.EmailConfirmed = faker.Random.Bool();
                entity.PasswordHash = new PasswordHasher<User<TKey>>().HashPassword(null, "secret");
                entity.SecurityStamp = Guid.NewGuid().ToString();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                entity.PhoneNumber = faker.Phone.PhoneNumber();
                entity.PhoneNumberConfirmed = faker.Random.Bool();
                entity.TwoFactorEnabled = faker.Random.Bool();
                //ToDo entity.LockoutEnd = faker.Date.Random;
                entity.LockoutEnabled = faker.Random.Bool();
                entity.AccessFailedCount = faker.Random.Number(100);
                users.Add(entity);
            }

            var roleNames = configuration.GetSection("Catalogs:Roles").Get<List<string>>();
            var roles = new List<Role<TKey>>();
            foreach (var role in roleNames)
            {
                var CreatedAt = faker.Date.Past(5);
                var entity = new Role<TKey>();
                entity.Id = (typeof(TKey) == typeof(Guid)) ? Guid.NewGuid().ChangeType<TKey>() : (TKey)Convert.ChangeType(counter, typeof(TKey));
                entity.Description = faker.Commerce.ProductDescription();
                entity.ExchangeId = Guid.NewGuid().ToString();
                entity.CreatedAt = CreatedAt;
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Name = role;
                entity.NormalizedName = entity.Name.Trim().ToUpper().Normalize();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                roles.Add(entity);
            }

            //Fill tables
            //modelBuilder.Entity<AdditionalInformation<TKey>().HasData(additionalInformation);
            modelBuilder.Entity<Bank<TKey>>().HasData(banks);
            modelBuilder.Entity<BankAccount<TKey>>().HasData(bankAccounts);
            modelBuilder.Entity<CashDesk<TKey>>().HasData(cashDescks);
            modelBuilder.Entity<ClientContactInformationType<TKey>>().HasData(clientContactInformationTypes);
            modelBuilder.Entity<ClientContactInformation<TKey>>().HasData(clientContactInformatinModel);
            modelBuilder.Entity<User<TKey>>().HasData(users);
            modelBuilder.Entity<Role<TKey>>().HasData(roles);
            //modelBuilder.Entity<ClientContract<TKey>().HasData(clientContracts);
            modelBuilder.Entity<Currency<TKey>>().HasData(currencies);
            modelBuilder.Entity<DocumentStatus<TKey>>().HasData(documentStatuses);
            modelBuilder.Entity<DocumentType<TKey>>().HasData(documentTypes);
            modelBuilder.Entity<Organization<TKey>>().HasData(organizations);
            modelBuilder.Entity<PriceType<TKey>>().HasData(priceTypes);
            modelBuilder.Entity<ProductUnitClassifier<TKey>>().HasData(productUnitClassifiers);
            modelBuilder.Entity<ProductUnitMeasurement<TKey>>().HasData(productUnitMeasurements);
            modelBuilder.Entity<ProductCharacteristic<TKey>>().HasData(productCharacteristics);
            modelBuilder.Entity<ProductQuality<TKey>>().HasData(productQuality);
            modelBuilder.Entity<ProductQuantity<TKey>>().HasData(productQuantityes);
            modelBuilder.Entity<ProductSerie<TKey>>().HasData(productSeries);
            modelBuilder.Entity<ProductType<TKey>>().HasData(productTypes);
            modelBuilder.Entity<Storage<TKey>>().HasData(storages);
            modelBuilder.Entity<Subdivision<TKey>>().HasData(subdivisions);
            modelBuilder.Entity<Product<TKey>>().HasData(products);
        }
    }
}