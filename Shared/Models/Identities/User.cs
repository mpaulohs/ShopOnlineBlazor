using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models.Identities
{
    public class User<TKey> : IdentityUser<TKey>, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>

    {
        public string? ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [MaxLength(100)]
        public string? FirstName { get; set; }

        [MaxLength(100)]
        public string? MiddleName { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        public virtual ICollection<UserClaim<TKey>>? Claims { get; set; }

        public virtual ICollection<UserLogin<TKey>>? Logins { get; set; }

        public virtual ICollection<UserToken<TKey>>? Tokens { get; set; }

        public virtual ICollection<UserRole<TKey>>? UserRoles { get; set; }
        public string GetName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
