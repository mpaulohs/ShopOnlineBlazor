using Microsoft.AspNetCore.Identity;

namespace SharedLib.Models.Identities
{
    public class UserLogin : IdentityUserLogin<Guid>

    {
        public virtual User? User { get; set; }
    }
}
