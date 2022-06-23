using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models.Catalogs
{
    public class AdditionalInformation<TKey> : CatalogBase<TKey>
    {
        public IApplicationEntity<TKey>? AppObject { get; set; }         

        [MaxLength(100)]
        public string? Description { get; set; }

        [MaxLength(500)]
        public string? Path { get; set; }
    }

}
