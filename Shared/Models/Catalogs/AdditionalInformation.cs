using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models.Catalogs
{
    public class AdditionalInformation<TKey> : CatalogBase<TKey>
    {
        public Type Type {get; set; }
        public TKey Owner {get; set;}       

        [MaxLength(100)]
        public string? Description { get; set; }

        [MaxLength(500)]
        public string? Path { get; set; }

        //ToDo
        // public AdditionalInformation(IApplicationEntity<TKey> entity, string description = default, string path = default)
        // {
        //     this.Type = entity.GetType();
        //     this.Owner = entity.Id;
        //     this.Description = description;
        //     this.Path = path;
        // }


    }
}
