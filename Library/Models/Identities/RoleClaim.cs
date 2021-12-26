using Microsoft.AspNetCore.Identity;
using System;

namespace ShopOnline.Library
{
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual Role Role { get; set; }
    }
}
