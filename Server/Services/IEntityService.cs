using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Server.Services
{
    public interface IEntityService<TEntity, TKey> where TEntity : class 

    {
        public Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);

        public Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);

        public Task<IEnumerable<TEntity>> GetByFiltersAsync(CancellationToken cancellationToken = default, params Expression<Func<TEntity, bool>>[] filters);

        public Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default);

        public Task<bool> UpdatePartyalAsync(TKey id, JsonPatchDocument entity, CancellationToken cancellationToken = default);

        public Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default);

        public Task<bool> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default);

        public Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
