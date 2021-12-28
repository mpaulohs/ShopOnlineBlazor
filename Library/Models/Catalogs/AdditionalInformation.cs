﻿using ShopOnline.Library.Services;
using System;

namespace ShopOnline.Library.Models.Catalogs
{
    public class AdditionalInformation : CatalogBase<Guid>
    {
        // public virtual IEntityBase<Guid> Entity { get; set; }

        public Guid EntityGuid { get; set; }

        public string EntityType { get; set; }

        public string Path { get; set; }
    }

}
