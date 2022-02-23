using Microsoft.AspNetCore.Identity;

namespace Shared.Models.Identities
{

    public class UserToken : IdentityUserToken<Guid>
    {
        public virtual User? User { get; set; }
    }
}
