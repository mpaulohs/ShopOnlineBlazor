using Microsoft.AspNetCore.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.Library.Identity
{
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual Role Role { get; set; }
    }
}
