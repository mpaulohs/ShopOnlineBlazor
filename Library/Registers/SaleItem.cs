using ShopOnlinePWA.Library.Catalogs;
using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.Library.Documents
{
   public class SaleItem : IEntityBase<Guid>
    {
        public Guid Id { get; set; }

        public Sale Sale { get; set; }

        public Item Item { get; set; }

        public ItemUnitMeasurement UtilMeasurement { get; set; }

        public ItemCharacteristic Characteristic { get; set; }

        public ItemSerie Serie { get; set; }

        public decimal Price { get; set; }

        public ItemQuality Quality { get; set; }

        public decimal Discount { get; set; }
        public string ExchangeId { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
