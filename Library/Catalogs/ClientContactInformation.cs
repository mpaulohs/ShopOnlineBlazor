using ShopOnlinePWA.Library.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class ClientContactInformation : CatalogBase<Guid>
    {
        public User Client { get; set; }

        public ClientContactInformationType ClientContactInformationType { get; set; }

        public string Value { get; set; }


    }
}
