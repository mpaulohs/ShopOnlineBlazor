namespace Shared.Models.Catalogs
{

    public class DocumentStatus<TKey> : CatalogBase<TKey>
         where TKey : IEquatable<TKey>
    {

    }


    // //ToDo: create this in config file
    // public enum DocumentStatus
    // {
    //     New,
    //     Inprocess,
    //     Acssepted,
    //     Denyed,
    // }
}
