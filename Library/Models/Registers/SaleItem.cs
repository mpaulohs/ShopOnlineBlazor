using ShopOnline.Library.Models.Catalogs;
using ShopOnline.Library.Models.Documents;
using ShopOnline.Library.Modesl;

namespace ShopOnline.Library.Models.Registers
{
    public class SaleItem : IApplicationEntity<Guid>
    {
        public Guid Id { get; set; }
        public DocumentSale? Document { get; set; }
        public Item? Item { get; set; }
        public ItemUnitMeasurement? UtilMeasurement { get; set; }
        public ItemCharacteristic? Characteristic { get; set; }
        public ItemSerie? Serie { get; set; }
        public ItemQuality? Quality { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Amount { get; set; }
        public string? ExchangeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? ConcurrencyStamp { get; set; }
    }
}
