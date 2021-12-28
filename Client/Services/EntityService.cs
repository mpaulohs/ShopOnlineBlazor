using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Client.Services
{
    public class EntityService<TEntity, TKey> : IEntityService<TEntity, TKey>
        where TEntity : class
    {
        public EntityService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public HttpClient HttpClient { get; }

        public Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetByFiltersAsync(CancellationToken cancellationToken = default, params Expression<Func<TEntity, bool>>[] filters)
        {
            return await HttpClient.GetFromJsonAsync<IEnumerable<TEntity>>("/api/order", cancellationToken);
        }

        public async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await HttpClient.GetFromJsonAsync<TEntity>($"/api/order/{id}", cancellationToken);
        }

        public async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await HttpClient.PutAsJsonAsync<TEntity>($"/api/order/{id}", entity, cancellationToken);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

      }
}
