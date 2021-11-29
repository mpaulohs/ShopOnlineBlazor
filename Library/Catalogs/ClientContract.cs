using ShopOnlinePWA.Library.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;


namespace ShopOnlinePWA.Library.Catalogs
{
    public class ClientContract : CatalogBase<Guid>
    {
        public User Client { get; set; }

        public Currency Currency { get; set; }

    }
}
