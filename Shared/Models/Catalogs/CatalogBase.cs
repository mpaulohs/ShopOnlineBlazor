using ShopOnline.Shared.Modesl;
using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Shared.Models.Catalogs
{
    public abstract class CatalogBase<TKey> : IApplicationEntity<TKey>
    {
        [MaxLength(50)]
        public TKey Id { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(200)]
        public string? Comment { get; set; }
    }
}
