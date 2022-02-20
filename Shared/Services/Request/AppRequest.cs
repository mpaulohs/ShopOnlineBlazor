using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Request
{
    internal class AppRequest : IAppRequest
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<(OrderType, String)>? OrderBy { get; set; } = null;
        public enum OrderType
        {
            Ascending,
            Descending
        }

        //public List<Func(bool res)>? Filters { get; set; } = null;
    }
}
