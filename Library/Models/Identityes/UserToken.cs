using Microsoft.AspNetCore.Identity;
using System;

namespace ShopOnlinePWA.Library
{

    public class UserToken : IdentityUserToken<Guid>
    {
        public virtual User User { get; set; }
    }
}
