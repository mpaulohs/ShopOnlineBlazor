using Shared.Models.Catalogs;
using Shared.Models.Documents;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models.Registers
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
