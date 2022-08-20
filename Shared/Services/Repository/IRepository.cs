using Microsoft.AspNetCore.JsonPatch;
using Shared.Models;
namespace Shared.Services.Repository
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
        public Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);
        public Task<(IEnumerable<TOut>,int)>? GetAsync<TOut>(string search = default, string filter = default, string sorts = default, int take = default, int skip = default, CancellationToken cancellationToken = default);
        public Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default);
        public Task<bool> UpdatePartyalAsync(TKey id, JsonPatchDocument entity, CancellationToken cancellationToken = default);
        public Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default);
        public Task<bool> DeleteAsync(TKey id, CancellationToken cancellationToken = default);
    }
}