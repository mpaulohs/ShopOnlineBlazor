namespace Shared.Models.Catalogs
{
    public class BankAccount<TKey> : CatalogBase<TKey>
    {
        public Bank<TKey>? Bank { get; set; }

    }
}
