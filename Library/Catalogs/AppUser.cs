﻿using Microsoft.AspNetCore.Identity;

namespace ShopOnlinePWA.Library.Catalogs
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

    }
}
