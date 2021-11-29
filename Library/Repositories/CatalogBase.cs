using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library.Repositories
{
    public abstract class CatalogBase<TId> : ICatalogBase<TId>
    {
        public TId Id { get; set; }
        public string ExchangeId { get; set; }
        public byte[] Timestamp { get; set; }
        public string Name {get; set;}
        public string Comment {get; set;}

    }
}
