using Microsoft.AspNetCore.Identity;

namespace SharedLib.Models.Identities
{

    public class UserToken : IdentityUserToken<Guid>
    {
        public virtual User? User { get; set; }
    }
}
