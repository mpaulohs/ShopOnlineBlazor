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
            var result = await this.RepositoryContext.Set<TEntity>().AddAsync(entity);
            return result.Entity.Id;
        }

        public async Task<IEnumerable<TEntity>> ReadAll()
        {
            return await RepositoryContext.Set<TEntity>().ToListAsync();//ToDo Check .AsNoTracking();
        }

        public async Task<TEntity> Read(TId id)
        {
            return await RepositoryContext.Set<TEntity>().SingleOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<IEnumerable<TEntity>> Read(Expression<Func<TEntity, bool>> expression)
        {
            return await RepositoryContext.Set<TEntity>().Where(expression).ToListAsync();//ToDo Check .AsNoTracking();
        }

        public async Task<TId> Update(TId id, TEntity entity)
        {
            var result = this.RepositoryContext.Set<TEntity>().Update(entity);
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
