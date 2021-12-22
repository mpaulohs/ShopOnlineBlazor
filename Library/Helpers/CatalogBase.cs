using System;

namespace ShopOnlinePWA.Library
{
    public abstract class CatalogBase<TKey> : IApplicationEntity<TKey>
    {
        public TKey Id { get; set; }
        public string ExchangeId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
        public string Comment { get; set; }
    }
}
