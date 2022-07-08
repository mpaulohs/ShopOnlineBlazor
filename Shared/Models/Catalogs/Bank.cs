namespace Shared.Models.Catalogs
{
    public class Bank<TKey> : CatalogBase<TKey>
where TKey : IEquatable<TKey>
    {
        public virtual IEnumerable<BankAccount<TKey>>? BankAccounts { get; set; }
    }
}
