using System.ComponentModel.DataAnnotations;

namespace SharedLib.Models.Catalogs
{
    public class Currency : CatalogBase<Guid>
    {
        [MaxLength(20)]
        public string? Code { get; set; }

        [MaxLength(20)]
        public string? Symbol { get; set; }
    }
}
