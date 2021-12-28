﻿using ShopOnline.Library.Models.Identities;
using ShopOnline.Library.Services;
using System;


namespace ShopOnline.Library.Models.Catalogs
{
    public class ClientContract : CatalogBase<Guid>
    {
        public User? Client { get; set; }

        public Currency? Currency { get; set; }

    }
}