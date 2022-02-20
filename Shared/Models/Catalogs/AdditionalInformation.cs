using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Shared.Models.Catalogs
{
    public class AdditionalInformation: CatalogBase<Guid>
    {
        public Guid EntityId { get; set; }

        [MaxLength(100)]
        public string? EntityType { get; set; }

        [MaxLength(500)]
        public string? Path { get; set; }
    }

}
