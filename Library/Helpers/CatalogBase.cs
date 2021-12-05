using System;

namespace ShopOnlinePWA.Library
{
    public abstract class CatalogBase<TId> : ICatalogBase<TId>
    {
        public TId Id { get; set; }
        public string ExchangeId { get; set; }
        public byte[] Timestamp
        {
            get
            {
                return this.Timestamp;
            }
            set
            {
                if (value == null)
                    this.Timestamp = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
                else
                    this.Timestamp = value;
            }
        }
        public string Name { get; set; }
        public string Comment { get; set; }

    }
}
