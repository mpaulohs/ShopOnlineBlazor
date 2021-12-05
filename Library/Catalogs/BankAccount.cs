using System;

namespace ShopOnlinePWA.Library
{
    public class BankAccount : CatalogBase<Guid>, IDocumentPaymentRessiver
    {
        public virtual Bank Bank { get; set; }

    }
}
