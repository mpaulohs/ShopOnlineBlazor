using Microsoft.Extensions.Logging;
using ShopOnline.API.Models;
using ShopOnline.API.Services;
using ShopOnline.Library.Models.Identities;
using System;

namespace ShopOnline.API.Repositories
{
    public class UserRepository : RepositoryBase<User, Guid, ApplicationDbContext>

    {
        public UserRepository(ApplicationDbContext context, ILogger<User> logger) : base(context, logger)
        {
        }
    }

}
