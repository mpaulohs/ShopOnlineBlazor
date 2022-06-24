using System;
using System.Collections.Generic;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Shared.Models.Catalogs;

namespace Api.Data
{
    public class SeedDb<TKey>
    {
        public SeedDb(ModelBuilder modelBuilder, int length)
        {
            var faker = new Faker();
            //Catalogs
            var products = new List<Product<TKey>>();
            for (int i = 0; i < length; i++)
            {
                var productCharacteristic = new ProductCharacteristic<TKey>();
                productCharacteristic.Id = (TKey)Convert.ChangeType(i, typeof(TKey));

            }


            for (int i = 1; i < length; i++)
            {
                var product = new Product<TKey>();
                product.Id = (TKey)Convert.ChangeType(i, typeof(TKey));
                product.FullName = faker.Commerce.Product();
                product.Name = product.FullName;
                product.Comment = faker.Lorem.Sentence();
                product.IsPublic = faker.Random.Bool();
                product.Article = faker.Commerce.Ean13();
                product.CreatedAt = faker.Date.Past(5);
                product.Description = faker.Commerce.ProductDescription();
                product.ConcurrencyStamp = Guid.NewGuid().ToString();
                //product.ProductCharacteristic

                products.Add(product);

                
            }

            modelBuilder.Entity<Product<TKey>>().HasData(products);
        }
    }
}