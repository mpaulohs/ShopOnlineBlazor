using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library.Repositories
{
    public interface ICatalogBase<TId>: IEntityBase<TId>
    {
        public string Name { get; set; }

        public string Comment { get; set; }

    }
}
