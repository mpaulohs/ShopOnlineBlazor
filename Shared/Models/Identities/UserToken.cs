using Microsoft.AspNetCore.Identity;

namespace Shared.Models.Identities
{

    public class UserToken<TKey> : IdentityUserToken<TKey>
        where TKey: IEquatable<TKey>
    {
        public virtual User<TKey>? User { get; set; }
    }
}
