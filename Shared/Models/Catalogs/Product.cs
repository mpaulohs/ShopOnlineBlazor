using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Catalogs
{
    public class Product<Tkey> : CatalogBase<Tkey>
    {
        public string? Article { get; set; }

        [MaxLength(255)]
        [Display(Name = "Full name")]
        public string? FullName { get; set; }

        public ProductType<Tkey>? ProductType { get; set; }

        public ProductCharacteristic<Tkey>? ProductCharacteristic { get; set; }

        public ProductQuality<Tkey>? ProductQuality { get; set; }

        public ProductSerie<Tkey>? ProductSerie { get; set; }

        public ProductUnitMeasurement<Tkey>? ProductUnitMeasurement { get; set; }

        public string? Description { get; set; }

        public string? MainImageUrl { get; set; } = "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg";

        public bool IsPublic { get; set; }


        public override string ToString()
        {

            return Name.ToString();
        }
    }
}
