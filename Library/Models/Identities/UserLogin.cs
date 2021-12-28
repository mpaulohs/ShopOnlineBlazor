using Microsoft.AspNetCore.Identity;
using System;

namespace ShopOnline.Library.Models.Identities
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public virtual User User { get; set; }
    }
}
