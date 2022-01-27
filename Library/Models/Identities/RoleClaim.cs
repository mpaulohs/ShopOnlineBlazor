using Microsoft.AspNetCore.Identity;

namespace ShopOnline.Shared.Models.Identities
{
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual Role? Role { get; set; }
    }
}
