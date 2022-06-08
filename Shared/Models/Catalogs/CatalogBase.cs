using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Catalogs
{
    public abstract class CatalogBase<TKey> : IApplicationEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(255)]
        public string? Comment { get; set; }

    }
}
