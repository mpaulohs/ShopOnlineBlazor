using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.ModelsRepository
{
    public interface IEntityRepository<TEntity>
    {
        public Task<ActionResult<TEntity>> Create(TEntity entity);

        public Task<ActionResult<IEnumerable<TEntity>>> Read();

        public Task<ActionResult<TEntity>> Read(Guid id);

        public Task<ActionResult<IEnumerable<TEntity>>> Read(IEnumerable<ShopOnlinePWA.Library.Helpers.RequestHelper<Object, Object>> requestHelpers);

        public Task<ActionResult<TEntity>> Update(TEntity entity);

        //ToDo Create method to update entity
        //public Task<ActionResult<TEntity>> Update(Guid quid, IDictionary<string, object> parameters);

        public Task<ActionResult> Delete();

        public Task<ActionResult> Delete(TEntity entity);

        public Task<ActionResult> Delete(Guid id);
    }
}


