using SharedLib.Models.Catalogs;

namespace SharedLib.Models.Documents
{
    public class DocumentPayment : DocumentBase<Guid>

    {
        public Currency? Currency { get; set; }


        //ToDo
        //public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
