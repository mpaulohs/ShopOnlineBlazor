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
using System.Text;
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
        protected virtual async Task<bool> SaveChanges(CancellationToken cancellationToken)
        {
            if (AutoSaveChanges)
            {
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
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
                return await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
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
                return await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
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
                return await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                throw new Exception(exception.Message, exception);
            }
        }
        public virtual async Task<bool> DeleteAsync(TKey id, CancellationToken cancellationToken = default)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                ThrowIfDisposed();
                var entity = await GetByIdAsync(id, cancellationToken);
                if (entity == default)
                {
                    _logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
                    throw new ArgumentNullException(nameof(entity));
                }
                //ToDo check if this is correct way
                _context.Remove<TEntity>(entity);
                return await SaveChanges(cancellationToken);
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<TOut>>? GetAsync<TOut>(
            string search = default,
            string filter = default,
            string sorts = default,
            int take = default,
            int skip = default,
            CancellationToken cancellationToken = default)
        {

            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            try
            {
                var entities = _entities;
                StringBuilder message = default;
                Expression<Func<TEntity, bool>> searchExp = default;
                Expression<Func<TEntity, bool>> filterExp = default;
                // Expression<Func<TOut, bool>> expOrderBy = default;
                var properties = typeof(TEntity).GetProperties().ToList();
                //Search
                if (search != default)
                {
                    foreach (var property in properties)
                    {
                        try
                        {
                            var searchStrExp = string.Format("entity => entity.{0}.Contains(\"{1}\")", property.Name, search);
                            var searchExpNew = FilterExtensions.ToExpression<TEntity>(searchStrExp);
                            if (searchExp == default)
                            {
                                searchExp = searchExpNew;
                            }
                            else
                            {
                                searchExp = searchExp.OrElse<TEntity>(searchExpNew);
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    if (searchExp != default)
                    {
                        entities = entities.Where<TEntity>(searchExp);
                    }
                }
                //Filter
                if (filter != default)
                {
                    var filterExpStrs = filter.Split(",", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var filterExpStr in filterExpStrs)
                    {
                        try
                        {
                            var filterExpNew = FilterExtensions.ToExpression<TEntity>(filterExpStr);
                            if (filterExp == default)
                            {
                                filterExp = filterExpNew;
                            }
                            else
                            {
                                filterExp = filterExp.AndAlso<TEntity>(filterExpNew);
                            }
                        }
                        catch (System.Exception exception)
                        {
                            _logger.LogError(exception.Message);
                            message.AppendFormat("error in filter expresion:\t{0}\n", filterExpStr);
                            continue;
                        }
                    }
                    if (filterExp != default)
                    {
                        entities = entities.Where<TEntity>(filterExp);
                    }
                }
                //OrderBy
                if (sorts != default)
                {
                    entities = entities.OrderBy<TEntity>(sorts);
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
    }
}
