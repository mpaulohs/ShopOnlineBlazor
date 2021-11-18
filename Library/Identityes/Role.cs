using Microsoft.AspNetCore.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;
using System.Collections.Generic;

namespace ShopOnlinePWA.Library.Identity
{

    public class Role : IdentityRole<Guid>, IEntityBase<Guid>
    {
        public string Description { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public virtual ICollection<RoleClaim> RoleClaims { get; set; }

    }
}
