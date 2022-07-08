namespace Shared.Models.Catalogs
{
    public class BankAccount<TKey> : CatalogBase<TKey>
where TKey : IEquatable<TKey>
    {
        public virtual Bank<TKey>? Bank { get; set; }

    }
}
