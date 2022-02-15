using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Identities;
using ShopOnline.Shared.Modesl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Shared.Models.Documents
{
    public abstract class DocumentBase<TKey> : IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public TKey? Id { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DocumentType DocumentType { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime ExchangeDateTime { get; set; }

        public Organization<TKey>? Organization { get; set; }

        public User<TKey>? Client { get; set; }

        public ClientContract<TKey>? ClientContract { get; set; }

        public PriceType<TKey>? PriceType { get; set; }

        public Currency<TKey>? DocumentCurrency { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DocumentCurrencyValue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MultiplicityMutalSettlements { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DocumentAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ContractAmount { get; set; }

        public User<Guid>? Responsible { get; set; }

        [MaxLength(255)]
        public string? Comment { get; set; }

        public Subdivision<TKey>? Subdivision { get; set; }

        [MaxLength(50)]
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }
}
