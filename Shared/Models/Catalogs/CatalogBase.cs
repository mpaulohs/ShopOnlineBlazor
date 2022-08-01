using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Catalogs
{
    public abstract class CatalogBase<TKey> : IApplicationEntity<TKey>
     where TKey : IEquatable<TKey>
    {
        [Key]
        public TKey Id { get; set; }

        public string? ExchangeId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; } = default;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = default;

        [MaxLength(50)]
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        [MaxLength(255)]
        public string? Comment { get; set; }
        public string GetName { get => this.Name; set => throw new NotImplementedException(); }

        public override string ToString() => string.IsNullOrEmpty(this.Name) ? string.Empty : this.Name;

    }
}
