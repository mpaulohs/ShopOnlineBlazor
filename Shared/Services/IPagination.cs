using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services
{
    public interface IPagination
    {
        public int PageNumber { get; set; }

        public int PageSize { set; get; }
              
    }
}
