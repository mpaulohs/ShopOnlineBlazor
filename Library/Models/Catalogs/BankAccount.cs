namespace ShopOnline.Shared.Models.Catalogs
{
    public class BankAccount : CatalogBase<Guid>
    {
        public virtual Bank? Bank { get; set; }

    }
}
