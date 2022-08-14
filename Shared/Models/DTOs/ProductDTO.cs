using Shared.Models.Catalogs;
namespace Shared.Models.Dtos;
public class ProductDTO<TKey>
where TKey : IEquatable<TKey>
{
    public TKey Id { get; set; }
    public string? ExchangeId { get; set; }
    public string? Name { get; set; } = default;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = default;
    public string? ConcurrencyStamp { get; set; }
    public string? Comment { get; set; }
    public string? Article { get; set; }
    public string? FullName { get; set; }
    public ICollection<ProductCharacteristic<TKey>>? ProductCharacteristics { get; set; }
    public bool IsPublic { get; set; }
    public string? MainImageUrl { get; set; }
    public string? ProductType { get; set; }
    public string? ProductQuality { get; set; }
    public string? ProductSerie { get; set; }
    public string? ProductUnitMeasurement { get; set; }
    public string? Description { get; set; }
}