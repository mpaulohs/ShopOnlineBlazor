using Microsoft.AspNetCore.Identity;

namespace ShopOnline.Shared.Models.Identities
{
    public class UserRole<TKey> : IdentityUserRole<TKey>
        where TKey : IEquatable<TKey>
    {
        public virtual User<TKey>? User { get; set; }
        public virtual Role<TKey>? Role { get; set; }

    }
}
