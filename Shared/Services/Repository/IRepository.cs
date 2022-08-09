using Microsoft.AspNetCore.JsonPatch;
using Shared.Models;
using Shared.Services.Request.Pagination;
using Shared.Services.Request.Search;
using System.Linq.Expressions;

namespace Shared.Services.Repository
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);

        public Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);

        // public Task<IEnumerable<TEntity>>? GetAsync(string fields = default, string search = default, string filter = default, string sorts = default, int pageSize = default, int pageCurrent = default, CancellationToken cancellationToken = default);

        public Task<IEnumerable<TOut>>? GetAsync<TOut>(
                string fields = default,
                string search = default,
                string filter = default,
                string orderby = default,
                int take = default,
                int skip = default,
                CancellationToken cancellationToken = default);

        public Task<IEnumerable<TEntity>>? GetAsync(string fields = default, string search = default, Expression<Func<TEntity, bool>>[] filters = default, string sorts = default, int pageSize = default, int pageCurrent = default, CancellationToken cancellationToken = default);

        public Task<IEnumerable<TOut>>? GetAsync<TOut>(Expression<Func<TEntity, bool>> select = default, Expression<Func<TEntity, bool>> where = default, Expression<Func<TEntity, bool>> orderBy = default, int pageSize = default, int pageCurrent = default, CancellationToken cancellationToken = default);

        public Task<PaginationList<TEntity>> GetByFiltersAsync(PaginationParameters paginationParameters, SearchParameters searchParameters = default, CancellationToken cancellationToken = default, Expression<Func<TEntity, bool>>[] filters = default);

        public Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default);

        public Task<bool> UpdatePartyalAsync(TKey id, JsonPatchDocument entity, CancellationToken cancellationToken = default);

        public Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default);

        public Task<bool> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default);

        public Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

    }
}