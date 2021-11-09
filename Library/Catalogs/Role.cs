using Microsoft.AspNetCore.Identity;

namespace ShopOnlinePWA.Library.Catalogs
{

    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}
