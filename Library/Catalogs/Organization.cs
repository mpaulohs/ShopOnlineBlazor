using System;
using System.ComponentModel.DataAnnotations;
using ShopOnlinePWA.Library.Repositories;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class Organization : IEntityBase<Guid>
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public string Name { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
