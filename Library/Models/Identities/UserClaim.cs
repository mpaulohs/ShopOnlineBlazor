using Microsoft.AspNetCore.Identity;

namespace ShopOnline.Library.Models.Identities
{

    public class UserClaim : IdentityUserClaim<Guid>
    {
        public virtual User? User { get; set; }
    }
}
