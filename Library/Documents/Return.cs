using ShopOnlinePWA.Library.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Documents
{
    public class Return : IEntityBase<Guid>
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
