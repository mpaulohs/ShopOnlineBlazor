using System;

namespace ShopOnlinePWA.Library
{
    public class DocumentPayment : DocumentBase<Guid>
    {
        public Currency Currency { get; set; }


        //ToDo
        //public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
