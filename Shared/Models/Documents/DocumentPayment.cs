using Shared.Models.Catalogs;

namespace Shared.Models.Documents
{
    public class DocumentPayment<TKey> : DocumentBase<TKey>
    where TKey : IEquatable<TKey>

    {
        public Currency<TKey>? Currency { get; set; }


        //ToDo
        //public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
