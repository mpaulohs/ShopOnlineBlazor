using Microsoft.AspNetCore.Identity;
using System;

namespace ShopOnlinePWA.Library
{
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual Role Role { get; set; }
    }
}
