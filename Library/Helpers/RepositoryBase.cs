using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library
{
    public abstract class RepositoryBase<TEntity, TKey, TContext> :
        IDisposable,
        IRepository<TEntity, TKey, TContext>
        where TEntity : class, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
        where TContext : DbContext
    {

        public RepositoryBase(TContext context, ILogger<TEntity> logger)
        {
            Context = context ?? throw new ArgumentNullException(nameof(Context));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        protected TContext Context { get; private set; }

        protected ILogger<TEntity> Logger { get; set; }

        public IQueryable<TEntity> Entities { get { return Context.Set<TEntity>(); } }

        /// <summary>
        /// Gets or sets a flag indicating if changes should be persisted after CreateAsync, UpdateAsync and DeleteAllAsync are called.
        /// </summary>
        /// <value>
        /// True if changes should be automatically persisted, otherwise false.
        /// </value>
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
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new ArgumentNullException(nameof(entity));
            }

            var result = await Context.Set<TEntity>().AddAsync(entity);

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception(exception.Message, exception);
            }
            return result.Entity.Id;
        }

        public virtual async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            return await Entities.SingleOrDefaultAsync(e => e.Id.Equals(id), cancellationToken);
        }

        public virtual async Task<IEnumerable<TEntity>> GetByFiltersAsync(CancellationToken cancellationToken = default, params Expression<Func<TEntity, bool>>[] filters)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            var entities = Entities;

            if (entities != null)
            {
                foreach (var filter in filters)
                {
                    entities = entities.Where(filter);
                }
            }
            return await entities.ToListAsync<TEntity>();
        }

        //public async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        //{
        //    cancellationToken.ThrowIfCancellationRequested();
        //    ThrowIfDisposed();

        //    bool haveChanges = false;

        //    if (entity == null)
        //    {
        //        Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
        //        throw new ArgumentNullException(nameof(entity));
        //    }

        //    var origEntity = await GetByIdAsync(id, cancellationToken);
        //    if (origEntity == null)
        //    {
        //        Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
        //        throw new NullReferenceException(nameof(origEntity));
        //    }


        //    Context.Attach(origEntity);



        //    //ToDo chec update process
        //    //entity.MapToModel(origEntity);

        //    foreach (var property in entity.GetType().GetProperties())
        //    {
        //        if (property.GetValue(entity, null) != default&& property.GetValue(entity, null) != null)
        //        {
        //            var origPropery = origEntity.GetType().GetProperty(property.Name);

        //            //ToDo not check equals
        //            if (origPropery.GetValue(origEntity, null) != property.GetValue(entity, null))
        //            {
        //                origPropery.SetValue(origEntity, property.GetValue(entity, null));
        //                haveChanges = true;
        //            }

        //            //property.SetValue(entity, origEntity.GetType().GetProperty(property.Name).GetValue(origEntity, null));

        //            //origEntity.GetType().GetProperty(property.Name).SetValue(entity, property.GetValue(entity, null));
        //        }
        //    }

        //    if (haveChanges)
        //    {
        //        origEntity.ConcurrencyStamp = Guid.NewGuid().ToString();

        //        Context.Update(origEntity);
        //        try
        //        {
        //            await SaveChanges(cancellationToken);
        //        }
        //        catch (Exception exception)
        //        {
        //            Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
        //            throw new Exception(exception.Message, exception);
        //        }
        //        return true;

        //    }
        //    return false;

        //}

        public virtual async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            //bool haveChanges = false;

            if (entity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new ArgumentNullException(nameof(entity));
            }

            var origEntity = await GetByIdAsync(id, cancellationToken);
            if (origEntity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new NullReferenceException(nameof(origEntity));
            }


            Context.Attach(origEntity);



            //ToDo chec update process
            //entity.MapToModel(origEntity);



            Context.Update(origEntity);
            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception(exception.Message, exception);
            }
            return true;



        }

        public virtual async Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            var entityes = Entities;
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
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
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
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new ArgumentNullException(nameof(id));
            }

            var entity = await this.Entities.SingleOrDefaultAsync(e => e.Id.Equals(id));

            return await DeleteAsync(entity, cancellationToken);
        }



        public virtual async Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (entity == null)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new ArgumentNullException(nameof(entity));
            }

            Context.Remove(entity);

            try
            {
                await SaveChanges(cancellationToken);
            }
            catch (Exception exception)
            {
                Logger.LogError("An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                throw new Exception(exception.Message, exception);
            }
            return true;
        }
    }
}
