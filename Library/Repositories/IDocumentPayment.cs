using ShopOnlinePWA.Library.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library.Repositories
{
    internal interface IDocumentPayment
    {
        public Currency Currency { get; set; }  
    }
}
