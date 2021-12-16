using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations;
using ShopOnlinePWA.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopOnlinePWA.API.Models
{
    public abstract class RepositoryBase<TEntity, TId> : IRepositoryBase<TEntity, TId> where TEntity : class, IEntityBase<TId>
    {
        protected AppDbContext RepositoryContext { get; set; }

        protected ILogger<TEntity> Logger { get; set; }

        public RepositoryBase(AppDbContext repositoryContext, ILogger<TEntity> logger)
        {
            this.RepositoryContext = repositoryContext;
            this.Logger = logger;
        }

        public async Task<TId> Create(TEntity entity)
        {
            var result = await RepositoryContext.Set<TEntity>().AddAsync(entity);
            await RepositoryContext.SaveChangesAsync();
            return result.Entity.Id;
        }

        public async Task<IEnumerable<TEntity>> ReadAll()
        {
            IQueryable<TEntity> query = RepositoryContext.Set<TEntity>();
            return await query.ToListAsync();
            // return await RepositoryContext.Set<TEntity>().ToListAsync();//ToDo Check .AsNoTracking();
            //return RepositoryContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public async Task<TEntity> Read(TId id)
        {
            return await RepositoryContext.Set<TEntity>().SingleOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<IEnumerable<TEntity>> Read(params Expression<Func<TEntity, bool>>[] filters)
        {
            IQueryable<TEntity> query = RepositoryContext.Set<TEntity>();

            if (filters != null)
            {
                foreach (var filter in filters)
                {
                    query = query.Where(filter);
                }
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<TId> Update(TId id, TEntity entity)
        {
            var result = await RepositoryContext.Set<TEntity>().AddAsync(entity);
            return result.Entity.Id;
        }

        public async Task<bool> Delete()
        {
            try
            {
                var entityes = this.RepositoryContext.Set<TEntity>();
                foreach (var entity in entityes)
                {
                    entityes.Remove(entity);
                }
                return true;

            }
            catch (Exception ex)
            {
                this.Logger.LogError(ex, "An error ocur Delete entity");
                return false;
            }
        }

        public async Task<bool> Delete(TId id)
        {
            var entity = await this.RepositoryContext.Set<TEntity>().SingleOrDefaultAsync(e => e.Id.Equals(id));
            if (entity == null)
            {
                return false;
            }
            this.RepositoryContext.Set<TEntity>().Remove(entity);
            return true;
        }
    }
}
