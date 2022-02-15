using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Modesl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Shared.Models.Registers
{
    public class SaleProduct<TKey> : IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public TKey Id { get; set; }

        public DocumentSale<TKey>? Document { get; set; }

        public Product<TKey>? Product { get; set; }

        public ProductUnitMeasurement<TKey>? UtilMeasurement { get; set; }

        public ProductCharacteristic<TKey>? Characteristic { get; set; }

        public ProductSerie<TKey>? Serie { get; set; }

        public ProductQuality<TKey>? Quality { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Amount { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string? ConcurrencyStamp { get; set; }
    }
}
