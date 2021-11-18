using Microsoft.AspNetCore.Identity;
using System;

namespace ShopOnlinePWA.Library.Identity
{

    public class UserClaim : IdentityUserClaim<Guid>
    {
        public virtual User User { get; set; }
    }
}
