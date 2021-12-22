using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library
{
    public class ItemQuantity
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
