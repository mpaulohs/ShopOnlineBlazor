using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Models;
using ShopOnlinePWA.Library;
using System;

namespace ShopOnlinePWA.API.Repositories
{
    public class UserRepository : RepositoryBase<User, Guid, ApplicationDbContext>

    {
        public UserRepository(ApplicationDbContext context, ILogger<User> logger) : base(context, logger)
        {
        }
    }

}
