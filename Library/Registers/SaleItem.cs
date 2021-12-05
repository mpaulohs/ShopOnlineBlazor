using System;

namespace ShopOnlinePWA.Library
{
    public class SaleItem : IEntityBase<Guid>
    {
        public Guid Id { get; set; }

        public IDocumentSale Document { get; set; }

        public Item Item { get; set; }

        public ItemUnitMeasurement UtilMeasurement { get; set; }

        public ItemCharacteristic Characteristic { get; set; }

        public ItemSerie Serie { get; set; }

        public ItemQuality Quality { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal Discount { get; set; }

        public decimal Amount { get; set; }

        public string ExchangeId { get; set; }

        public byte[] Timestamp { get; set; }
    }
}
