namespace Shared.Models.Catalogs
{
    public class ClientContactInformationType<TKey> : CatalogBase<TKey>
     where TKey : IEquatable<TKey>
    {
       public ICollection<ClientContactInformation<TKey>>? ClientContactInformations { get; set; }

    }
}
