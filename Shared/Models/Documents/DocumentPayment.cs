using Shared.Models.Catalogs;

namespace Shared.Models.Documents
{
    public class DocumentPayment<Tkey> : DocumentBase<Tkey>

    {
        public Currency<Tkey>? Currency { get; set; }


        //ToDo
        //public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
