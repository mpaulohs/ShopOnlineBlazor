using Shared.Models.Catalogs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models.Registers
{
    public class ProductPrice<Tkey>
    {
        public Guid Id { get; set; }
        public PriceType<Tkey>? PriceType { get; set; }
        public Product<Tkey>? Product { get; set; }
        public Currency<Tkey>? Currency { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
