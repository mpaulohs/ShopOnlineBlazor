using Microsoft.AspNetCore.Identity;

namespace SharedLib.Models.Identities
{
    public class RoleClaim : IdentityRoleClaim<Guid>

    {
        public virtual Role? Role { get; set; }
    }
}
