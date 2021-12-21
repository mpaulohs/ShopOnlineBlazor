using System;

namespace ShopOnlinePWA.Library
{
    public interface IUserStore : IEntityStore<User, Guid, ApplicationDbContext>
    {
    }
}
