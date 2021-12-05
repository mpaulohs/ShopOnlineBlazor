using System;

namespace ShopOnlinePWA.Library
{
    public class DocumentPayment : DocumentBase<Guid>, IDocumentPayment
    {
        public Currency Currency { get; set; }
        public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
