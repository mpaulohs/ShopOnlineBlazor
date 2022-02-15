using ShopOnline.Shared.Modesl;
using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Shared.Models.Documents
{
    public class Mesage<TKey> : IApplicationEntity<TKey>
    {
        public TKey Id { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string? ConcurrencyStamp { get; set; }
    }
}
