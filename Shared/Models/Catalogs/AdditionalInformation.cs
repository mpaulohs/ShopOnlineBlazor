using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
namespace Shared.Models.Catalogs
{
    public class AdditionalInformation<TKey> : CatalogBase<TKey>
where TKey : IEquatable<TKey>
    {
        private Type? entityType;
        public string? EntityType
        {
            get => JsonSerializer.Serialize<Type>(entityType);
            set => this.entityType = JsonSerializer.Deserialize<Type>(value);
        }
        public TKey? EntityId { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [MaxLength(500)]
        public string? Path { get; set; }
    }
}
