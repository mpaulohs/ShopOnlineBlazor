using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library
{
    public interface IEntityBase<TKey>
    {
        public TKey Id { get; set; }

        public string ExchangeId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public string ConcurrencyStamp { get; set; }
    }
}
