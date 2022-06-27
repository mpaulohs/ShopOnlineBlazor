using System;
using System.Collections.Generic;
using System.Configuration;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Shared.Models.Catalogs;

namespace Api.Data
{
    public static class SeedDb<TKey>
    where TKey : IEquatable<TKey>
    {

        public static void Fill(int length, IConfiguration configuration, ModelBuilder modelBuilder = default)
        {
            var faker = new Faker();

            //Catalogs

            var banks = new List<Bank<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Bank<TKey>();
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
                entity.Id = default;
                entity.Name ="Bank " + faker.Company.CompanyName();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                banks.Add(entity);
            }

            var bankAccounts = new List<BankAccount<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new BankAccount<TKey>();
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
                entity.Name = "Bank account: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                bankAccounts.Add(entity);
            }

            var cashDescks = new List<CashDesk<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new CashDesk<TKey>();
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
                entity.Name = clientContactInformatinTypeName[i];
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                clientContactInformationTypes.Add(entity);
            }

            var clientContactInformation = new List<ClientContactInformation<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ClientContactInformation<TKey>();
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
                entity.Name = faker.Address.FullAddress();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                entity.ClientContactInformationType = faker.PickRandom<ClientContactInformationType<TKey>>(clientContactInformationTypes);
                clientContactInformation.Add(entity);
            }

            var currencies = configuration.GetSection("Catalogs:Currency").Get<List<Currency<TKey>>>();
            for (int i = 0; i < currencies.Count; i++)
            {
                var entity = currencies[i];
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
            }

            var documentStatusNames = configuration.GetSection("Catalogs:DocumentStatus").Get<List<string>>();
            var documentStatuses = new List<DocumentStatus<TKey>>();
            for (int i = 0; i < documentStatusNames.Count; i++)
            {
                var entity = new DocumentStatus<TKey>();
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
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
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
                entity.Name = "Subdivision: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                subdivisions.Add(entity);
            }

            var products = new List<Product<TKey>>();
            for (int i = 1; i < length; i++)
            {
                var entity = new Product<TKey>();
                //entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Id = default;
                entity.Name = faker.Commerce.Product();
                entity.Name = entity.Name;
                entity.FullName = faker.Commerce.Product();
                entity.CreatedAt = faker.Date.Past(5);
                entity.UpdatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                entity.IsPublic = faker.Random.Bool();
                entity.Article = faker.Commerce.Ean13();
                entity.Description = faker.Commerce.ProductDescription();
                entity.MainImageUrl = faker.Image.Random.ToString();
                entity.Description = faker.Lorem.Paragraph();
                entity.ProductCharacteristic = faker.PickRandom<ProductCharacteristic<TKey>>(productCharacteristics);
                entity.ProductQuality = faker.PickRandom<ProductQuality<TKey>>(productQuality);
                entity.ProductSerie = faker.PickRandom<ProductSerie<TKey>>(productSeries);
                entity.ProductType = faker.PickRandom<ProductType<TKey>>(productTypes);
                entity.ProductUnitMeasurement = faker.PickRandom<ProductUnitMeasurement<TKey>>(productUnitMeasurements);
                products.Add(entity);
            }

            //modelBuilder.Entity<AdditionalInformation<TKey>().HasData(additionalInformation);
            if (modelBuilder == default)
            {
                modelBuilder = new ModelBuilder();
            }
            modelBuilder.Entity<Bank<TKey>>().HasData(banks);
            modelBuilder.Entity<BankAccount<TKey>>().HasData(bankAccounts);
            modelBuilder.Entity<CashDesk<TKey>>().HasData(cashDescks);
            modelBuilder.Entity<ClientContactInformationType<TKey>>().HasData(clientContactInformationTypes);
            modelBuilder.Entity<ClientContactInformation<TKey>>().HasData(clientContactInformation);
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