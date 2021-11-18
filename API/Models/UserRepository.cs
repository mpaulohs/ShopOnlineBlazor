using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations.AppIdentityDb;
using ShopOnlinePWA.Library.Identity;
using System;

namespace ShopOnlinePWA.API.Models
{
    public class UserRepository : RepositoryBase<User, Guid>, IUserRepository
    {
        public UserRepository(AppDbContext RepositoryContext, ILogger Logger) : base(RepositoryContext, Logger)
        {
        }
    }

}
