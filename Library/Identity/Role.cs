using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ShopOnlinePWA.Library.Identity
{

    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<RoleClaim> RoleClaims { get; set; }

    }
}
