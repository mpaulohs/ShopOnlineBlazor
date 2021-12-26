using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Library
{
    public class Mesage : IApplicationEntity<Guid>
    {
        public Guid Id { get; set; }
        public string ExchangeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ConcurrencyStamp { get; set; }
    }
}
