using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ShopOnline.Library
{
    public class User : IdentityUser<Guid>, IApplicationEntity<Guid>
    {
        public string ExchangeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<UserClaim> Claims { get; set; }

        public virtual ICollection<UserLogin> Logins { get; set; }

        public virtual ICollection<UserToken> Tokens { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}
