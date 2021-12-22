using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Models;
using ShopOnlinePWA.Library;
using System;

namespace ShopOnlinePWA.API.Repositories
{
    public class UserStore : EntityStore<User, Guid, ApplicationDbContext>

    {
        public UserStore(ApplicationDbContext context, ILogger<User> logger) : base(context, logger)
        {
        }
    }

}
