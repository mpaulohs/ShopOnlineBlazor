﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace ShopOnlinePWA.Library
{
    public interface IEntityStore<TEntity, TKey, TContext>
        where TEntity : class, IEntityBase<TKey>
        where TKey : IEquatable<TKey>
        where TContext : DbContext

    {
        public Task<TKey> CreateAsync (TEntity entity, CancellationToken cancellationToken = default);


        public Task<TEntity> GetByIdAsync (TKey id, CancellationToken cancellationToken = default);


        public Task<IEnumerable<TEntity>> GetByFiltersAsync (CancellationToken cancellationToken = default, params Expression<Func<TEntity, bool>>[] filters);


        public Task<bool> UpdateAsync (TEntity entity, CancellationToken cancellationToken = default);


        public Task<bool> DeleteAllAsync (CancellationToken cancellationToken = default);


        public Task<bool> DeleteByIdAsync (TKey id, CancellationToken cancellationToken = default);



        public Task<bool> DeleteAsync (TEntity entity, CancellationToken cancellationToken = default);

    }
}