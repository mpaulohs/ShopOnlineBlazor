using System;

namespace ShopOnline.Library
{
    public class Currency : CatalogBase<Guid>
    {
        public string Code { get; set; }

        public string Symbol { get; set; }
    }
}
