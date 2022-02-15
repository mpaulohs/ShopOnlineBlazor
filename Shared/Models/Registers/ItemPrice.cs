using ShopOnline.Shared.Models.Catalogs;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Shared.Models.Registers
{
    public class ProductPrice<TKey>
    {
        public TKey Id { get; set; }
        public PriceType<TKey>? PriceType { get; set; }
        public Product<TKey>? Product { get; set; }
        public Currency<TKey>? Currency { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
