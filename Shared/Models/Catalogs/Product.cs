using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Catalogs
{
    public class Product<TKey> : CatalogBase<TKey>
where TKey : IEquatable<TKey>
    {
        public string? Article { get; set; }

        [MaxLength(255)]
        [Display(Name = "Full name")]
        public string? FullName { get; set; }

        public virtual ProductType<TKey>? ProductType { get; set; }

        public virtual ICollection<ProductCharacteristic<TKey>>? ProductCharacteristics { get; set; }

        public virtual ProductQuality<TKey>? ProductQuality { get; set; }

        public virtual ProductSerie<TKey>? ProductSerie { get; set; }

        public virtual ProductUnitMeasurement<TKey>? ProductUnitMeasurement { get; set; }

        public string? Description { get; set; }

        public string? MainImageUrl { get; set; } = "https://assets-global.website-files.com/600fe6e1ff56087409a9f096/605b5a558848493df14d2d13_ecommerce-product-photography.jpg";

        public bool IsPublic { get; set; }


        public override string ToString()
        {
            return string.Format("{0} {1)", base.ToString(), this.FullName);
        }
    }
}
