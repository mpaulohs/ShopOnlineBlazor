using System;


namespace ShopOnline.Library
{
    public class ClientContract : CatalogBase<Guid>
    {
        public User Client { get; set; }

        public Currency Currency { get; set; }

    }
}
