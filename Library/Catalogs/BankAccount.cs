using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class BankAccount
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public Bank Bank { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
