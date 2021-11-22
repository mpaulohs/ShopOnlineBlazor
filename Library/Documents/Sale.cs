using ShopOnlinePWA.Library.Catalogs;
using ShopOnlinePWA.Library.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnlinePWA.Library.Documents
{
    public class Sale : IEntityBase<Guid>
    {
        public Guid Id { get; set; }

        public int ExchangeId { get; set; }

        public DateTime Date { get; set; }

        public User Client { get; set; }

        public ClientContract Contract { get; set; }

        public User Reciver { get; set; }

        public Currency Currency { get; set; }

        public DocumentType DocumentType { get; set; }

        public DocumentStatus documentStatus { get; set; }

        public string Coment { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
