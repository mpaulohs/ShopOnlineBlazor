using Shared.Models.Identities;

namespace Shared.Models.Catalogs
{
    public class ClientContract<TKey> : CatalogBase<TKey>
    {
        public User<TKey>? Client { get; set; }

        public Currency<TKey>? Currency { get; set; }

    }
}
