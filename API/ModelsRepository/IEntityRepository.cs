using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.ModelsRepository
{
    public interface IEntityRepository<TEntity>
    {
        public Task<TEntity> Create(TEntity entity);

        public Task<ICollection<TEntity>> Read();

        public Task<TEntity> Read(Guid id);

        public Task<ICollection<TEntity>> Read(IDictionary<string, object> parameters);

        public Task<TEntity> Update(TEntity entity);

        public Task<TEntity> Update(Guid quid, IDictionary<string, object> parameters);

        public Task Delete();

        public Task Delete(TEntity entity);

        public Task Delete(Guid id);
    }
}


