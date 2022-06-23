using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Identities
{

    public class Role : IdentityRole<Guid>, IApplicationEntity<Guid>

    {
        [MaxLength(500)]
        public string? Description { get; set; }

        public virtual ICollection<UserRole>? UserRoles { get; set; }

        public virtual ICollection<RoleClaim>? RoleClaims { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Role(string De)
        {
            
        }
    }
}
