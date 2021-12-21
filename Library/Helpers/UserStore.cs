using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace ShopOnlinePWA.Library
{
    public class UserStore<TEntity, TKey, TContext> : EntityStore<TEntity, TKey, TContext>, IEntityStore<TEntity, TKey, TContext>
        where TEntity : class, IEntityBase<TKey>
        where TKey : IEquatable<TKey>
        where TContext : DbContext
    {
        public UserStore(TContext context, ILogger<TEntity> logger) : base(context, logger)
        {
        }
    }

}
