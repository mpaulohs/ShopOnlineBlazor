using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Shared.Models.Catalogs
{
    public class Product<TKey> : CatalogBase<TKey>
    {
        public string? Article { get; set; }

        [MaxLength(255)]
        [Display(Name = "Full name")]
        public string? FullName { get; set; }

        public ProductType<TKey>? ProductType { get; set; }

        public ProductCharacteristic<TKey>? ProductCharacteristic { get; set; }

        public ProductQuality<TKey>? ProductQuality { get; set; }

        public ProductSerie<TKey>? ProductSerie { get; set; }

        public ProductUnitMeasurement<TKey>? ProductUnitMeasurement { get; set; }

        public string? Description { get; set; }

        public string? MainImageUrl { get; set; } = "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg";

        public bool IsPublic { get; set; }

    }
}
