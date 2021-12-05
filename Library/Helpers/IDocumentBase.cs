using System;

namespace ShopOnlinePWA.Library
{
    public interface IDocumentBase<TId> : IEntityBase<TId>
    {
        public DocumentType DocumentType { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime ExchangeDateTime { get; set; }

        public Organization Organization { get; set; }

        public Subdivision Subdivision { get; set; }

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
    }
}
