namespace SharedLib.Models.Catalogs
{
    public class BankAccount : CatalogBase<Guid>
    {
        public Bank? Bank { get; set; }

    }
}
