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
    {
        public static void Seed (int length, IConfiguration configuration, ModelBuilder modelBuilder = default)
        {
            var clientContactInformatinType = configuration.GetSection("Catalogs:ClientContactInformationType").Get<List<ClientContactInformationType<Guid>>>(); //ClientContactInformationType").Get<List<ClientContactInformationType<Guid>>>();
            var currency = configuration.GetSection("Catalogs:Currency").Get<List<Currency<Guid>>>();


            var faker = new Faker();
            //Catalogs

            var productCharacteristics = new List<ProductCharacteristic<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var entity = new ProductCharacteristic<TKey>();

                entity.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                entity.Name = entity.Name;
                entity.CreatedAt = faker.Date.Past(5);
                entity.CreatedAt = faker.Date.Between(entity.CreatedAt, DateTime.Now);
                entity.Comment = faker.Lorem.Sentence();
                entity.ConcurrencyStamp = Guid.NewGuid().ToString();

                productCharacteristics.Add(entity);
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
                products.Add(entity);
            }

            // modelBuilder.Entity<ProductCharacteristic<TKey>>().HasData(productCharacteristics);
            // modelBuilder.Entity<Product<TKey>>().HasData(products);
        }
    }
}