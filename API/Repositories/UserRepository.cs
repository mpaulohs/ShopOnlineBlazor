using Microsoft.Extensions.Logging;
using ShopOnline.API.Models;
using ShopOnline.Library;
using ShopOnline.Library.Models.Identities;
using ShopOnline.Library.Services;
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
