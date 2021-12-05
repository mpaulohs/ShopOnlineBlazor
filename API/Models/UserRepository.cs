using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations;
using ShopOnlinePWA.Library;
using System;

namespace ShopOnlinePWA.API.Models
{
    public class UserRepository : RepositoryBase<User, Guid>, IUserRepository
    {
        public UserRepository(AppDbContext RepositoryContext, ILogger<User> Logger) : base(RepositoryContext, Logger)
        {
        }
    }

}
