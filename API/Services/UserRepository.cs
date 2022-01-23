using Microsoft.Extensions.Logging;
using ShopOnline.API.Migrations;
using ShopOnline.Library.Models.Identities;
using System;

namespace ShopOnline.API.Services
{
    public class UserRepository : RepositoryBase<User, Guid>

    {
        public UserRepository(ApplicationDbContext context, ILogger<User> logger) : base(context, logger)
        {
        }
    }

}
