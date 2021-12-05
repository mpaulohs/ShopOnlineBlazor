using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library
{
    public interface IRepositoryBase<TEntity, TId> where TEntity : class, IEntityBase<TId>
    {
        public Task<TId> Create(TEntity entity);

        public Task<IEnumerable<TEntity>> ReadAll();

        public Task<TEntity> Read(TId id);

        public Task<IEnumerable<TEntity>> Read(Expression<Func<TEntity, bool>> expression);

        public Task<TId> Update(TId id, TEntity entity);

        public Task<bool> Delete();

        public Task<bool> Delete(TId id);
    }
}


