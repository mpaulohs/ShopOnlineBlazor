using ShopOnline.Library.Models.Identities;
using ShopOnline.Library.Services;
using System;

namespace ShopOnline.Library.Models.Catalogs
{
    public class ClientContactInformation : CatalogBase<Guid>
    {
        public User Client { get; set; }

        public ClientContactInformationType ClientContactInformationType { get; set; }

        public string Value { get; set; }


    }
}
