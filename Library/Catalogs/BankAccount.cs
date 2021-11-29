using ShopOnlinePWA.Library.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class BankAccount : CatalogBase<Guid>
    {
        public virtual Bank Bank { get; set; }

    }
}
