using Microsoft.AspNetCore.Identity;

namespace Shared.Models.Identities
{
    public class RoleClaim<TKey> : IdentityRoleClaim<TKey>
        where TKey: IEquatable<TKey>

    {
        public virtual Role<TKey>? Role { get; set; }
    }
}
