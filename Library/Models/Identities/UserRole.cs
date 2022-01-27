using Microsoft.AspNetCore.Identity;

namespace ShopOnline.Shared.Models.Identities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public virtual User? User { get; set; }
        public virtual Role? Role { get; set; }

    }
}
