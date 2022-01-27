using ShopOnline.Shared.Models.Catalogs;

namespace ShopOnline.Shared.Models.Documents
{
    public class DocumentPayment : DocumentBase<Guid>
    {
        public Currency? Currency { get; set; }


        //ToDo
        //public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
