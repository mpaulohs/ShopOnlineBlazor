using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library
{
    public class Mesage : IEntityBase<Guid>
    {
        public Guid Id { get; set; }
        public string ExchangeId { get; set; }
        public byte[] CreatedAt { get; set; }
        public byte[] UpdatedAt { get; set; }
        public string ConcurrencyStamp { get; set; }
    }
}
