namespace Shared.Models.Catalogs
{

    public class DocumentType<TKey> : CatalogBase<TKey>
where TKey : IEquatable<TKey>
    {

    }

    // //ToDo create this in config file
    // public enum DocumentType
    // {
    //     Adjustment,
    //     Mesage,
    //     Order,
    //     Payment,
    //     Returns,
    //     Sale
    // }
}
