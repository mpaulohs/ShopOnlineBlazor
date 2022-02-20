using ShopOnline.Shared.Models.Catalogs;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Shared.Models.Registers
{
    public class ProductPrice
    {
        public Guid Id { get; set; }
        public PriceType? PriceType { get; set; }
        public Product? Product { get; set; }
        public Currency? Currency { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
