using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library
{
    public interface IEntityStore<TEntity, TKey, TContext>:
        IDisposable
        where TEntity : class
    {
        public Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

        public Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default(CancellationToken));

        public Task<IEnumerable<TEntity>> GetByFiltersAsync(CancellationToken cancellationToken = default(CancellationToken), params Expression<Func<TEntity, bool>>[] filters);

        public Task<bool> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

        public Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default(CancellationToken));

        public Task<bool> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default(CancellationToken));

        public Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

    }
}


