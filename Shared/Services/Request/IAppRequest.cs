using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services.Request
{
    public interface IAppRequest
    {
        public int Limit { get; set; }

        public int Offset { get; set; }

    }
}
