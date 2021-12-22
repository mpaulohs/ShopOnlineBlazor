using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace ShopOnlinePWA.Library
{
    public class UserStore : EntityStore<User, Guid, ApplicationDbContext>

    {
        public UserStore(ApplicationDbContext context, ILogger<User> logger) : base(context, logger)
        {
        }
    }

}
