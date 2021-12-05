namespace ShopOnlinePWA.Library
{
    internal interface IDocumentPayment
    {
        public IDocumentPaymentRessiver PaymentRessiver { get; set; }
    }
}
