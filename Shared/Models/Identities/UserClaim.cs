using Microsoft.AspNetCore.Identity;

namespace SharedLib.Models.Identities
{

    public class UserClaim : IdentityUserClaim<Guid>

    {
        public virtual User? User { get; set; }
    }
}
