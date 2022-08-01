using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Identities
{

    public class Role<TKey> : IdentityRole<TKey>, IApplicationEntity<TKey>
    where TKey : IEquatable<TKey>

    {
        [MaxLength(500)]
        public string? Description { get; set; }

        public virtual ICollection<UserRole<TKey>>? UserRoles { get; set; }

        public virtual ICollection<RoleClaim<TKey>>? RoleClaims { get; set; }

        [MaxLength(50)]
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        public string GetName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
