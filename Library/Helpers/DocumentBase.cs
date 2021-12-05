using System;

namespace ShopOnlinePWA.Library
{
    public abstract class DocumentBase<TId> : IDocumentBase<TId>
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
        public DocumentType DocumentType { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime ExchangeDateTime { get; set; }
        public Organization Organization { get; set; }
        public User Client { get; set; }
        public ClientContract ClientContract { get; set; }
        public PriceType PriceType { get; set; }
        public Currency DocumentCurrency { get; set; }
        public decimal DocumentCurrencyValue { get; set; }
        public decimal MultiplicityMutalSettlements { get; set; }
        public decimal DocumentAmount { get; set; }
        public decimal ContractAmount { get; set; }
        public IDocumentBase<TId> RefDocument { get; set; }
        public User Responsible { get; set; }
        public string Comment { get; set; }
        public Subdivision Subdivision { get; set; }
        decimal IDocumentBase<TId>.DocumentCurrencyValue { get; set; }
        decimal IDocumentBase<TId>.MultiplicityMutalSettlements { get; set; }
        decimal IDocumentBase<TId>.DocumentAmount { get; set; }
        decimal IDocumentBase<TId>.ContractAmount { get; set; }
        DateTime IDocumentBase<TId>.ExchangeDateTime { get; set; }
    }
}
