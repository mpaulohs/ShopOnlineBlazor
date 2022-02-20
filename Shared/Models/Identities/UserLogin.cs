using Microsoft.AspNetCore.Identity;

namespace ShopOnline.Shared.Models.Identities
{
    public class UserLogin : IdentityUserLogin<Guid>

    {
        public virtual User? User { get; set; }
    }
}
