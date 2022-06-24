using Shared.Models.Identities;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Catalogs
{
    public class ClientContactInformation<TKey> : CatalogBase<TKey>
        where TKey: IEquatable<TKey>
    {
        public User<TKey>? Client { get; set; }

        public ClientContactInformationType<TKey>? ClientContactInformationType { get; set; }

        [MaxLength(255)]
        public string? Value { get; set; }


    }
}
