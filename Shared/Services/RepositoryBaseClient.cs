using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopOnline.Shared.Modesl;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace ShopOnline.Shared.Services 
{ 
    public class RepositoryBaseClient<TEntity, TKey> :
        IDisposable,
        IRepository<TEntity, TKey>
        where TEntity : class, IApplicationEntity<TKey>
        where TKey : IEquatable<TKey>
    {

        public RepositoryBaseClient(HttpClient httpClient, ILogger<TEntity> logger)
        {
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            Url = "api/" + typeof(TEntity).Name.ToLower() + "/";
        }

        protected string Url { get; set; }
        protected HttpClient HttpClient { get; private set; }

        protected ILogger<TEntity> Logger { get; set; }

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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetByFiltersAsync(CancellationToken cancellationToken = default, params Expression<Func<TEntity, bool>>[] filters)
        {
            
            return await HttpClient.GetFromJsonAsync<IEnumerable<TEntity>>(Url, cancellationToken);
        }

        public async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
                  return await HttpClient.GetFromJsonAsync<TEntity>(Url, cancellationToken);

        }

        public async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await HttpClient.PutAsJsonAsync<TEntity>(Url + id.ToString(), entity, cancellationToken);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<bool> UpdatePartyalAsync(TKey id, JsonPatchDocument entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
