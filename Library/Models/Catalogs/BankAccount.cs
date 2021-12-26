using System;

namespace ShopOnline.Library
{
    public class BankAccount : CatalogBase<Guid>
    {
        public virtual Bank Bank { get; set; }

    }
}
