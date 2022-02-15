using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Shared.Models.Catalogs
{
    public class Currency<TKey> : CatalogBase<TKey>
    {
        [MaxLength(20)]
        public string? Code { get; set; }

        [MaxLength(20)]
        public string? Symbol { get; set; }
    }
}
