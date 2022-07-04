namespace Shared.Models.Catalogs
{
    public class ProductCharacteristic<TKey> : CatalogBase<TKey>
where TKey : IEquatable<TKey>
    {
        public virtual ICollection<Product<TKey>>? Products { get; set; }

    }
}
