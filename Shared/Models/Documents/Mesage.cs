using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Documents
{
    public class Mesage : IApplicationEntity<Guid>
    {
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(50)]
        public string? ConcurrencyStamp { get; set; }
    }
}
