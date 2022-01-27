using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Modesl;

namespace ShopOnline.Shared.Models.Registers
{
    public class SaleProduct : IApplicationEntity<Guid>
    {
        public Guid Id { get; set; }
        public DocumentSale? Document { get; set; }
        public Product? Product { get; set; }
        public ProductUnitMeasurement? UtilMeasurement { get; set; }
        public ProductCharacteristic? Characteristic { get; set; }
        public ProductSerie? Serie { get; set; }
        public ProductQuality? Quality { get; set; }
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
