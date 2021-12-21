using System;

namespace ShopOnlinePWA.Library
{
    public abstract class CatalogBase<TKey> : ICatalogBase<TKey>
    {
        public TKey Id { get; set; }
        public string ExchangeId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public byte[] Timestamp { get; set; }
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }
}
