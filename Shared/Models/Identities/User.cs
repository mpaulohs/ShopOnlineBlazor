using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SharedLib.Models.Identities
{
    public class User : IdentityUser<Guid>, IApplicationEntity<Guid>

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

        public virtual ICollection<UserClaim>? Claims { get; set; }

        public virtual ICollection<UserLogin>? Logins { get; set; }

        public virtual ICollection<UserToken>? Tokens { get; set; }

        public virtual ICollection<UserRole>? UserRoles { get; set; }

    }
}
