using ShopOnline.Library.Models.Catalogs;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Library.Models.Registers
{
    public class ItemPrice
    {
        public Guid Id { get; set; }
        public PriceType PriceType { get; set; }
        public Item Item { get; set; }
        public Currency Currency { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }



    }
}
