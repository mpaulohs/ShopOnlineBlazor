using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ShopOnlinePWA.Library.Identity
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<UserClaim> Claims { get; set; }

        public virtual ICollection<UserLogin> Logins { get; set; }

        public virtual ICollection<UserToken> Tokens { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }


    }
}
