using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Shared.Models.Catalogs
{
    public class Product : CatalogBase<Guid>
    {
        public string? Article { get; set; }

        [Display(Name = "Full name")]
        public string? FullName { get; set; }

        public ProductType? ProductType { get; set; }

        public ProductCharacteristic? ProductCharacteristic { get; set; }

        public ProductQuality? ProductQuality { get; set; }

        public ProductSerie? ProductSerie { get; set; }

        public ProductUnitMeasurement? ProductUnitMeasurement { get; set; }

        public string? Description { get; set; }

        public string? MainImageUrl { get; set; }

    }
}
