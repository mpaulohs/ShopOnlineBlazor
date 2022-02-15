using ShopOnline.Shared.Models.Identities;


namespace ShopOnline.Shared.Models.Catalogs
{
    public class ClientContract<TKey> : CatalogBase<TKey>
    {
        public User<Guid>? Client { get; set; }

        public Currency<Guid>? Currency { get; set; }

    }
}
