using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnlinePWA.Library
{
    public abstract class DocumentBase<TKey> : IDocumentBase<TKey>
    {
        public TKey Id { get; set; }
        public string ExchangeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DocumentType DocumentType { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime ExchangeDateTime { get; set; }
        public Organization Organization { get; set; }
        public User Client { get; set; }
        public ClientContract ClientContract { get; set; }
        public PriceType PriceType { get; set; }
        public Currency DocumentCurrency { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DocumentCurrencyValue { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MultiplicityMutalSettlements { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DocumentAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ContractAmount { get; set; }
        //public IDocumentBase<TKey> RefDocument { get; set; }
        public User Responsible { get; set; }
        public string Comment { get; set; }
        public Subdivision Subdivision { get; set; }
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }
}
