using Microsoft.AspNetCore.Identity;
using System;

namespace ShopOnline.Library
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public virtual User User { get; set; }
    }
}
