using SharedLib.Models.Identities;

namespace SharedLib.Models.Catalogs
{
    public class ClientContract : CatalogBase<Guid>
    {
        public User? Client { get; set; }

        public Currency? Currency { get; set; }

    }
}
