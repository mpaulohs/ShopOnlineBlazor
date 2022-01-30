using Microsoft.AspNetCore.JsonPatch;
using ShopOnline.Shared.Modesl;
using System.Linq.Expressions;

namespace ShopOnline.Shared.Services
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
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