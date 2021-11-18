using ShopOnlinePWA.Library.Identity;
using System.ComponentModel.DataAnnotations;


namespace ShopOnlinePWA.Library.Catalogs
{
    class ClientContract
    {
        public int ExchangeId { get; set; }

        public string Name { get; set; }

        public User Client { get; set; }

        public Currency Currency { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
