using Microsoft.AspNetCore.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.Library.Identity
{

    public class UserToken : IdentityUserToken<Guid>
    {
        public virtual User User { get; set; }
    }
}
