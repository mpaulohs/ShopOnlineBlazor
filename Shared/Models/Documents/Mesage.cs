using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Documents
{
    public class Mesage<TKey> : IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        [Key]
        public TKey Id { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string? ConcurrencyStamp { get; set; }

        public string Text { get; set; } = default;
        public string GetName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return this.Text.ToString();
        }
    }
}
