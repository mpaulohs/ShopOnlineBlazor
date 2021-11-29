using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class Currency : CatalogBase<Guid>
    {
        public string? Code { get; set; }

        public string? Symbol { get; set; }

        public Currency(string Name, string? Code = null, string? Symbol = null )
        {

            this.Id = Guid.NewGuid();
           // this.Timestamp = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
            this.Name = Name;
            this.Code = Code;
            this.Symbol = Symbol;

        }

    }
}
