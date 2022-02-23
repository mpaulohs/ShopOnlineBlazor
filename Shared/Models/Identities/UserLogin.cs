using Microsoft.AspNetCore.Identity;

namespace Shared.Models.Identities
{
    public class UserLogin : IdentityUserLogin<Guid>

    {
        public virtual User? User { get; set; }
    }
}
