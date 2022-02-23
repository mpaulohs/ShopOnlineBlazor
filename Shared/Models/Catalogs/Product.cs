using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Catalogs
{
    public class Product : CatalogBase<Guid>
    {
        public string? Article { get; set; }

        [MaxLength(255)]
        [Display(Name = "Full name")]
        public string? FullName { get; set; }

        public ProductType? ProductType { get; set; }

        public ProductCharacteristic? ProductCharacteristic { get; set; }

        public ProductQuality? ProductQuality { get; set; }

        public ProductSerie? ProductSerie { get; set; }

        public ProductUnitMeasurement? ProductUnitMeasurement { get; set; }

        public string? Description { get; set; }

        public string? MainImageUrl { get; set; } = "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg";

        public bool IsPublic { get; set; }

    }
}
