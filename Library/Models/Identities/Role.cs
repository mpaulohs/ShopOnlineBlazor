﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ShopOnlinePWA.Library
{

    public class Role : IdentityRole<Guid>, IEntityBase<Guid>
    {
        public string Description { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
        public string ExchangeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
