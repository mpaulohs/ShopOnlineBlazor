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
using System.Linq;
using System.Linq.Dynamic.Core;
using Shared.Services.Repository;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Api.Data
{
    public class RepositoryBaseApi<TEntity, TKey, TDbContext> :
        IDisposable,
        IRepository<TEntity, TKey>
        where TEntity : class, IApplicationEntity<TKey>
        where TDbContext : DbContext
        where TKey : IEquatable<TKey>
    {

        public RepositoryBaseApi(IMapper mapper, TDbContext context, ILogger<TEntity> logger)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._context = context ?? throw new ArgumentNullException(nameof(context));
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        protected IMapper _mapper { get; private set; }

        protected TDbContext _context { get; private set; }

        protected ILogger<TEntity> _logger { get; private set; }

        protected IQueryable<TEntity> _entities { get { return _context.Set<TEntity>(); } }

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

                await _context.SaveChangesAsync(cancellationToken);
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
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }

            //Change properyes before Creating
            entity.Id = default;
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = default;

            //Before Context.Set<TEntity>().AddAsync(entity);
            var result = await _context.AddAsync(entity, cancellationToken);

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return result.Entity.Id;
        }

        public virtual async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            return await _entities.AsNoTracking().SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public virtual async Task<string>? GetNameByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            var entity = await _entities.AsNoTracking().SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
            return entity?.ToString();
        }

        public virtual async Task<PaginationList<TEntity>>? GetByFiltersAsync(PaginationParameters paginationParameters, SearchParameters searchParameters = default, CancellationToken cancellationToken = default, Expression<Func<TEntity, bool>>[] filters = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            var entities = _entities;

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

        public virtual async Task<IEnumerable<TEntity>>? GetAsync(
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

            var entities = this._entities;

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

            return await entities.OrderBy<TEntity>(sorts: sorts).ToListAsync<TEntity>();
        }

        public virtual async Task<bool> UpdateAsync(TKey id, TEntity newEntity, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (newEntity == null)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(newEntity));
            }

            var origEntity = await GetByIdAsync(id, cancellationToken);
            if (origEntity == null)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new NullReferenceException(nameof(origEntity));
            }

            //ToDo: Check about paralel changed models
            //Context.Attach(origEntity);

            newEntity.Id = id;
            newEntity.CreatedAt = origEntity.CreatedAt;
            newEntity.UpdatedAt = DateTime.Now;
            //ToDo update ConcurrencyStamp
            newEntity.ConcurrencyStamp = origEntity.ConcurrencyStamp;

            try
            {
                _context.Update(newEntity);
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
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
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }

            // works var origEntity = await Entities.SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken); 
            var origEntity = await GetByIdAsync(id, cancellationToken);

            if (origEntity == null)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new NullReferenceException(nameof(origEntity));
            }

            try
            {
                _context.Attach(origEntity);
                entity.ApplyTo(origEntity);
                origEntity.UpdatedAt = DateTime.Now;
                origEntity.Id = id;
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return true;
        }

        public virtual async Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            var entityes = _entities;
            foreach (var entity in entityes)
            {
                _context.Remove(entity);
            }

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
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
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(id));
            }

            var entity = await GetByIdAsync(id, cancellationToken);

            if (entity == null)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
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
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new ArgumentNullException(nameof(entity));
            }

            _context.Remove(entity);

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
            return true;
        }

        public async Task<IEnumerable<TEntity>>? GetAsync(
            string fields = default,
            string search = default,
            Expression<Func<TEntity,
            bool>>[] filters = default,
            string sorts = default,
            int pageSize = default,
            int pageCurrent = default,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            ThrowIfDisposed();

            var entities = this._entities;

            if (entities == null)
            {
                return null;
            }

            //select
            if (fields != default)
            {
                entities = entities.Select<TEntity>(fields);
            }
            //search
            // if (search != default)
            // {
            //     var searchs = search.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //     entities = entities.Where<TEntity>(e => searchs.Contains(e.Id.ToString()));
            // }

            //Where
            if (filters != default)
            {
                foreach (var filter in filters)
                {
                    entities = entities.Where(filter);
                }
            }

            //OrderBy
            if (sorts != default)
            {
                entities = entities.OrderBy<TEntity>(sorts);
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

        public async Task<IEnumerable<TOut>>? GetAsync<TOut>(
            string fields = default,
            string search = default,
            string filter = default,
            string orderby = default,
            int take = default,
            int skip = default,
            CancellationToken cancellationToken = default)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();

                ThrowIfDisposed();

                var entities = _entities;

                //ToDo use global configuration
                // var entities = mapper.ProjectTo<TOut>(this.entities);

                if (entities == null)
                {
                    //ToDo hendle this result
                    return null;
                }

                Expression<Func<TEntity, bool>> expSelect = default;
                Expression<Func<TEntity, bool>> expSearch = default;
                Expression<Func<TEntity, bool>> expFilter = default;
                // Expression<Func<TOut, bool>> expOrderBy = default;
                var properties = typeof(TEntity).GetProperties().ToList();

                //select
                if (fields != default)
                {
                    //var fieldList = fields.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(field => field.Trim());
                    //properties = properties.Where(property => fieldList.Contains(property.Name)).ToList();

                    //ToDo check do we nead use this select
                    entities = entities.Select<TEntity>(fields);
                }

                //Search
                if (search != default)
                {
                    foreach (var property in properties)
                    {
                        try
                        {
                            var strexpSearch = string.Format("entity => entity.{0}.Contains(\"{1}\")", property.Name, search);
                            var expSearchNew = FilterExtensions.ToExpression<TEntity>(strexpSearch);
                            if (expSearch == default)
                            {
                                expSearch = expSearchNew;
                            }
                            else
                            {
                                //expSearch = System.Linq.Expressions.OrElse(expSearch, expSearchNew);
                                expSearch = expSearch.OrElse<TEntity>(expSearchNew);
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }

                    if (expSearch != default)
                    {
                        entities = entities.Where<TEntity>(expSearch);
                    }
                }

                //Filter
                if (filter != default)
                {
                    var queryExpressions = filter.Split(",", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var queryEppression in queryExpressions)
                    {
                        try
                        {
                            var expFilterNew = FilterExtensions.ToExpression<TEntity>(queryEppression);
                            if (expFilter == default)
                            {
                                expFilter = expFilterNew;
                            }
                            else
                            {
                                expFilter = expFilter.AndAlso<TEntity>(expFilterNew);
                            }
                        }
                        catch (System.Exception exception)
                        {
                            _logger.LogError(exception.Message);
                            continue;
                        }
                    }

                    if (expFilter != default)
                    {
                        entities = entities.Where<TEntity>(expFilter);
                    }
                }

                // //Where (combinaton search exp and filter exp)
                // Expression<Func<TOut, bool>> where = default;

                // if (expSearch != default && expFilter != default)
                // {
                //     where = expSearch.AndAlso<TOut>(expFilter);
                // }
                // else
                // {
                //     where = expSearch != default ? expSearch : expFilter;
                // }

                // if (where != default)
                // {
                //     entities = entities.Where(where);
                // }

                //OrderBy
                if (orderby != default)
                {
                    entities = entities.OrderBy<TEntity>(orderby);
                }

                //Skip
                if (skip != default)
                {
                    entities = entities.Skip<TEntity>(skip);
                }

                //Take
                if (take != default)
                {
                    entities = entities.Take<TEntity>(take);
                }

                var configuration = new MapperConfiguration(cfg => cfg.CreateProjection<TEntity, TOut>());

                // var entities = _entities.ProjectTo<TOut>(_mapper.ConfigurationProvider);
                var result = await entities.ProjectTo<TOut>(configuration).ToListAsync<TOut>();
                //var res = await entities.ToListAsync<TOut>(); // entities.ProjectTo<TOut>().Expression.ToListAsync();
                return result;
            }
            catch (Exception exception)
            {
                //ToDo make handler for this epxeption
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new NotImplementedException();
            }
        }

        public Task<IEnumerable<TOut>> GetAsync<TOut>(Expression<Func<TEntity, bool>> select = null, Expression<Func<TEntity, bool>> where = null, Expression<Func<TEntity, bool>> orderBy = null, int pageSize = 0, int pageCurrent = 0, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
