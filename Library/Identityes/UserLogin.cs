using Microsoft.AspNetCore.Identity;
using System;

namespace ShopOnlinePWA.Library.Identity
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public virtual User User { get; set; }
    }
}
