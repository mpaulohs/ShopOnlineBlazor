using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library.Repositories
{
    public interface IEntityBase<TId>
    {
        public TId Id { get; set; }
    }
}
