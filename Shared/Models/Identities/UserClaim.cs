using Microsoft.AspNetCore.Identity;

namespace Shared.Models.Identities
{

    public class UserClaim<TKey> : IdentityUserClaim<TKey>
        where TKey: IEquatable<TKey>

    {
        public virtual User<TKey>? User { get; set; }
    }
}
