using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Documents
{
    public class Sale
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
