namespace Shared.Models.Catalogs
{
    public class ClientContactInformationType<TKey> : CatalogBase<TKey>
     where TKey : IEquatable<TKey>
    {
        public virtual ICollection<ClientContactInformation<TKey>>? ClientContactInformations { get; set; }
    }
}
