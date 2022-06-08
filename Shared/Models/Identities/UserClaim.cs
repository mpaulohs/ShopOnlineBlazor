using Microsoft.AspNetCore.Identity;

namespace Shared.Models.Identities
{

    public class UserClaim : IdentityUserClaim<Guid>

    {
        public virtual User? User { get; set; }
    }
}
