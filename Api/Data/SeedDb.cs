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
        public static void Seed(int length, IConfiguration configuration, ModelBuilder modelBuilder = default)
        {
            var faker = new Faker();

            //Catalogs

            var banks = new List<Bank<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Bank<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = faker.Company.CompanyName();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                banks.Add(entity);
            }

            var bankAccounts = new List<BankAccount<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new BankAccount<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Bank account: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                bankAccounts.Add(entity);
            }

            var cashDescks = new List<CashDesk<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new CashDesk<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Cash desk: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                cashDescks.Add(entity);
            }

            var clientContactInformatinTypeName = configuration.GetSection("Catalogs:ClientContactInformationType").Get<List<ClientContactInformationType<Guid>>>();
            var clientContactInformationTypes = new List<ClientContactInformationType<TKey>>();
            for (int i = 0; i < clientContactInformatinTypeName.Count; i++)
            {
                var entity = new ClientContactInformationType<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = clientContactInformatinTypeName[i].Name;
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                clientContactInformationTypes.Add(entity);
            }

            var clientContactInformation = new List<ClientContactInformation<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ClientContactInformation<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = faker.Address.FullAddress();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                entity.ClientContactInformationType = faker.PickRandom<ClientContactInformationType<TKey>>(clientContactInformationTypes);
                clientContactInformation.Add(entity);
            }

            var productCharacteristics = new List<ProductCharacteristic<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductCharacteristic<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = faker.Commerce.Color();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productCharacteristics.Add(entity);
            }

            var productQuality = new List<ProductQuality<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductQuality<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Product quaity: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productQuality.Add(entity);
            }

            var productQuantityes = new List<ProductQuantity<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductQuantity<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Product quanity: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productQuantityes.Add(entity);
            }

            var productSeries = new List<ProductSerie<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductSerie<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Product serie: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productSeries.Add(entity);
            }

            var productTypes = new List<ProductType<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductType<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Product type: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productTypes.Add(entity);
            }

            var productUnitClassifiers = new List<ProductUnitClassifier<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductUnitClassifier<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Product unit classifier: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productUnitClassifiers.Add(entity);
            }

            var productUnitMeasurements = new List<ProductUnitMeasurement<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductUnitMeasurement<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Product unit measurement: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                productUnitMeasurements.Add(entity);
            }

            var storages = new List<Storage<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Storage<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Storage: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                storages.Add(entity);
            }

            var subdivisions = new List<Subdivision<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new Subdivision<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = "Subdivision: " + faker.Lorem.Word();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                subdivisions.Add(entity);
            }

            var products = new List<Product<TKey>>();
            for (int i = 1; i < length; i++)
            {
                var entity = new Product<TKey>();
                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = faker.Commerce.Product();
                entity.Name = entity.Name;
                entity.FullName = faker.Commerce.Product();
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();
                entity.IsPublic = faker.Random.Bool();
                entity.Article = faker.Commerce.Ean13();
                entity.Description = faker.Commerce.ProductDescription();
                entity.ProductCharacteristic = faker.PickRandom<ProductCharacteristic<TKey>>(productCharacteristics);
                entity.MainImageUrl = faker.Image.Random.ToString();
                //entity.ProductCharacteristic
                products.Add(entity);
            }

            // modelBuilder.Entity<ProductCharacteristic<TKey>>().HasData(productCharacteristics);
            // modelBuilder.Entity<Product<TKey>>().HasData(products);
            
        }
    }
}