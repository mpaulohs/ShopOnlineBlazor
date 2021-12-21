using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ShopOnlinePWA.Library
{
    public class User : IdentityUser<Guid>, IEntityBase<Guid>
    {
        public string ExchangeId { get; set; }

        public byte[] Timestamp { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<UserClaim> Claims { get; set; }

        public virtual ICollection<UserLogin> Logins { get; set; }

        public virtual ICollection<UserToken> Tokens { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}
