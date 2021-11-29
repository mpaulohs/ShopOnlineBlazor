using ShopOnlinePWA.Library.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class AdditionalInformation : CatalogBase<Guid>
    {
        public virtual IEntityBase<Guid> Entity { get; set; }

        public string Path { get; set; }
    }

}
