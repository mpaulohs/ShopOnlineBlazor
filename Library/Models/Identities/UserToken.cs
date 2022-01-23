using Microsoft.AspNetCore.Identity;

namespace ShopOnline.Library.Models.Identities
{

    public class UserToken : IdentityUserToken<Guid>
    {
        public virtual User? User { get; set; }
    }
}
