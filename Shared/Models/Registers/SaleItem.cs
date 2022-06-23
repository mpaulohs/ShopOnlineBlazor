using Shared.Models.Catalogs;
using Shared.Models.Documents;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models.Registers
{
    public class SaleProduct<Tkey> : IApplicationEntity<Tkey>

    {
        public Tkey Id { get; set; }

        public DocumentSale<Tkey>? Document { get; set; }

        public Product<Tkey>? Product { get; set; }

        public ProductUnitMeasurement<Tkey>? UtilMeasurement { get; set; }

        public ProductCharacteristic<Tkey>? Characteristic { get; set; }

        public ProductSerie<Tkey>? Serie { get; set; }

        public ProductQuality<Tkey>? Quality { get; set; }

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
