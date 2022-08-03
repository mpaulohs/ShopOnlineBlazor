using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shared.Models;
using Shared.Services.Request.Pagination;
using Shared.Services.Request.Search;
using System.Linq.Expressions;
using Shared.Services.Repository.RepositoryExtentions;
using Shared.Models.Catalogs;
using Shared.Services.Request.Sort;
using Shared.Services.Request.Select;

namespace Shared.Services.Repository
{
    public class RepositoryBaseApi<TEntity, TKey, TDbContext> :
        IDisposable,
        IRepository<TEntity, TKey>
        where TEntity : class, IApplicationEntity<TKey>
        where TDbContext : DbContext
        where TKey : IEquatable<TKey>
    {

        public RepositoryBaseApi(TDbContext context, ILogger<TEntity> logger)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected TDbContext Context { get; private set; }

        protected ILogger<TEntity> Logger { get; set; }

        public IQueryable<TEntity> AllEntities { get { return Context.Set<TEntity>(); } }


        public bool AutoSaveChanges { get; set; } = true;

        private bool _disposed;

        /// <summary>
        /// Throws if this class has been disposed.
        /// </summary>
        protected void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        /// <summary>
        /// Dispose the stores
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            // Dispose of managed resources here.
            if (disposing)
            {
                _disposed = true;
            }
        }

        /// <summary>Saves the current store.</summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task"/> that represents the asynchronous operation.</returns>
        protected virtual async Task SaveChanges(CancellationToken cancellationToken)
        {
            if (AutoSaveChanges)
            {

                await Context.SaveChangesAsync(cancellationToken);
            }
        }

        /// <summary>
        /// Creates a new role in a store as an asynchronous operation.
        /// </summary>
        /// <param name="entity">The entity in the store.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>A <see cref="Task{TResult}"/> that represents the <see cref="IdentityResult"/> of the asynchronous query.</returns>
        public virtual async Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            if (entity == null)
            {
                //ToDo: Change results to Action results /return StatusCode
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }

            //Change properyes before Creating
            entity.Id = default;
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = default;

            //Before Context.Set<TEntity>().AddAsync(entity);
            var result = await Context.AddAsync(entity, cancellationToken);

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return result.Entity.Id;
        }

        public virtual async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            return await AllEntities.AsNoTracking().SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public virtual async Task<string>? GetNameByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            var entity = await AllEntities.AsNoTracking().SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
            return entity?.ToString();
        }

        public virtual async Task<PaginationList<TEntity>>? GetByFiltersAsync(PaginationParameters paginationParameters, SearchParameters searchParameters = default, CancellationToken cancellationToken = default, Expression<Func<TEntity, bool>>[] filters = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            var entities = AllEntities;

            if (entities == null)
            {
                return null;
            }

            //Search
            if (searchParameters != default && typeof(TEntity).IsSubclassOf(typeof(CatalogBase<TKey>)))
            {
                entities = entities.Search<TEntity, TKey>(searchParameters.SearchTerm);
            }

            //Filtering
            if (filters != null && filters?.Length > 0)
            {
                foreach (var filter in filters)
                {
                    entities = entities?.Where(filter);
                }
            }

            //int count = entities.Count();

            //Pagination
            //if (pagination!=null)
            //{
            //    entities = entities?
            //   .Skip((pagination.curentPage-1)*pagination.PageSize)
            //   .Take(pagination.PageSize);
            //}

            //OrderBy
            //entities = entities.OrderBy(e => e.CreatedAt);


            return PaginationList<TEntity>.ToPaginationList(entities, paginationParameters.curentPage, paginationParameters.PageSize);
        }

        public virtual async Task<List<TEntity>>? GetAsync(
            string fields = default,
            string search = default,
            string filter = default,
            string sorts = default,
            int pageSize = default,
            int curentPage = default,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            ThrowIfDisposed();

            var entities = AllEntities;

            if (entities == null)
            {
                return null;
            }
            //search
            if (search != default)
            {
                var searchs = search.Split(' ');
                entities = entities.Where<TEntity>(e => searchs.Contains(e.ToString()));
            }

            //filter
            // if (filter != default)
            // {
            //     var strExpression = FilterExpression.FilterExtensions.ToExpressionString(filter);
            //     var filterExpression = FilterExpression.FilterExtensions.ToExpression<TEntity, TKey>(strExpression);
            //     if (filterExpression != null)
            //     {
            //         entities = entities.Where(filterExpression);
            //     }
            // }

            //sort

            if (entities == default || sorts == default)
            {
                var res = entities.AsAsyncEnumerable<TEntity>();
                return await entities.ToListAsync<TEntity>();
            }

            return await entities.OrderBy<TEntity, TKey>(sorts: sorts).ToListAsync<TEntity>();
        }




        public virtual async Task<bool> UpdateAsync(TKey id, TEntity newEntity, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (newEntity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(newEntity));
            }

            var origEntity = await GetByIdAsync(id, cancellationToken);
            if (origEntity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new NullReferenceException(nameof(origEntity));
            }

            //ToDo: Check about paralel changed models
            //Context.Attach(origEntity);

            newEntity.Id = id;
            newEntity.CreatedAt = origEntity.CreatedAt;
            newEntity.UpdatedAt = DateTime.Now;
            newEntity.ConcurrencyStamp = origEntity.ConcurrencyStamp;

            try
            {
                Context.Update(newEntity);
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return true;
        }

        public virtual async Task<bool> UpdatePartyalAsync(TKey id, JsonPatchDocument entity, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (entity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }

            // works var origEntity = await Entities.SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken); 
            var origEntity = await GetByIdAsync(id, cancellationToken);

            if (origEntity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new NullReferenceException(nameof(origEntity));
            }

            try
            {
                Context.Attach(origEntity);
                entity.ApplyTo(origEntity);
                origEntity.UpdatedAt = DateTime.Now;
                origEntity.Id = id;
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return true;
        }

        public virtual async Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            var entityes = AllEntities;
            foreach (var entity in entityes)
            {
                Context.Remove(entity);
            }

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return true;
        }

        public virtual async Task<bool> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (id == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(id));
            }

            var entity = await GetByIdAsync(id, cancellationToken);

            if (entity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }

            return await DeleteAsync(entity, cancellationToken);
        }

        public virtual async Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (entity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }

            Context.Remove(entity);

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return true;
        }

        public async Task<IEnumerable<TEntity>>? GetAsync(string fields = default, string search = default, Expression<Func<TEntity, bool>>[] filters = default, string sorts = default, int pageSize = default, int pageCurrent = default, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            ThrowIfDisposed();

            var entities = AllEntities;

            if (entities == null)
            {
                return null;
            }

            //select
            if (fields != default)
            {
                entities = entities.Select<TEntity, TKey>(fields);
            }
            //search
            if (search != default)
            {
                var searchs = search.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                entities = entities.Where<TEntity>(e => searchs.Contains(e.Id.ToString()));
            }

            //Where
            // if (filters != default)
            // {
            //     foreach (var filter in filters)
            //     {
            //         entities = entities.Where(filter);
            //     }

            // }

            //OrderBy
            if (sorts != default)
            {
                entities = entities.OrderBy<TEntity, TKey>(sorts);
            }

            //Skip
            if (pageCurrent != default && pageCurrent > 1)
            {
                entities = entities.Skip((pageCurrent - 1) * pageSize);
            }

            //Take
            if (pageSize != default && pageSize > 0)
            {
                entities = entities.Take(pageSize);
            }

            return await entities.ToListAsync();
        }
    }
}
