using System;

namespace ShopOnlinePWA.Library
{
    public class BankAccount : CatalogBase<Guid>
    {
        public virtual Bank Bank { get; set; }

    }
}
