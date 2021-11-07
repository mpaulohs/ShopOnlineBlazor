using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnlineLIbrary.Models.Catalogs
{
    public class DocumentStatus
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
