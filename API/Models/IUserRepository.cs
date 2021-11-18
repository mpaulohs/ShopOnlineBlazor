using ShopOnlinePWA.Library.Identity;
using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.API.Models
{
    public interface IUserRepository : IRepositoryBase<User, Guid>
    {
    }
}
