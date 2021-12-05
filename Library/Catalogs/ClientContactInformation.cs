using System;

namespace ShopOnlinePWA.Library
{
    public class ClientContactInformation : CatalogBase<Guid>
    {
        public User Client { get; set; }

        public ClientContactInformationType ClientContactInformationType { get; set; }

        public string Value { get; set; }


    }
}
