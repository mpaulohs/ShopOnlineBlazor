using ShopOnline.Shared.Models.Identities;

namespace ShopOnline.Shared.Models.Catalogs
{
    public class ClientContactInformation : CatalogBase<Guid>
    {
        public User? Client { get; set; }

        public ClientContactInformationType? ClientContactInformationType { get; set; }

        public string? Value { get; set; }


    }
}
