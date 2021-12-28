using ShopOnline.Library.Services;
using System;

namespace ShopOnline.Library.Models.Catalogs
{
    public class BankAccount : CatalogBase<Guid>
    {
        public virtual Bank Bank { get; set; }

    }
}
