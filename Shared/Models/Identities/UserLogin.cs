using Microsoft.AspNetCore.Identity;

namespace ShopOnline.Shared.Models.Identities
{
    public class UserLogin<TKey> : IdentityUserLogin<TKey>
        where TKey: IEquatable<TKey>
    {
        public virtual User<TKey>? User { get; set; }
    }
}
