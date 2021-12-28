using Shared.Services;
using System;

namespace ShopOnline.Library.Models.Catalogs
{
    public class Currency : CatalogBase<Guid>
    {
        public string? Code { get; set; }

        public string? Symbol { get; set; }
    }
}
