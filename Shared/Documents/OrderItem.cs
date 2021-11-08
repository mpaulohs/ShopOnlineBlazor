using ShopOnlinePWA.Library.Catalogs;
using System;

namespace ShopOnlinePWA.Library.Documents
{
    class OrderItem
    {
        public Guid Id { get; set; }

        public Order Order { get; set; }

        public Item Item { get; set; }

        public ItemUnitMeasurement UtilMeasurement { get; set; }

        public ItemCharacteristic Characteristic { get; set; }

        public ItemSerie Serie { get; set; }

        public decimal Price { get; set; }

        public ItemQuality Quality { get; set; }

        public decimal Discount { get; set; }

    }
}
