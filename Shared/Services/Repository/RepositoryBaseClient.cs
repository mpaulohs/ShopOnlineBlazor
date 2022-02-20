using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.WebUtilities;
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

        public RepositoryBaseClient(HttpClient httpClient, NavigationManager navManager, ILogger<TEntity> logger)
        {
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            BaseUri = new Uri(HttpClient.BaseAddress + GetTypeName(typeof(TEntity)));
            Console.WriteLine(typeof(TEntity));
            //BaseUri = new Uri ("api/" + typeof(TEntity).Name.ToLower() + "/");
            //Url = "api/" + typeof(TEntity).Name.ToLower() + "/";
        }

        protected Uri BaseUri { get; set; }
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


        public async Task<(IEnumerable<TEntity> entities, int count)?> GetByFiltersAsync(CancellationToken cancellationToken = default, int limit = default, int offset = default, params Expression<Func<TEntity, bool>>[] filters)
        {
            var queryParams = new Dictionary<string, string>
            {
                ["limit"] = limit.ToString(),
                ["offset"] = offset.ToString(),
            };

            var result = await HttpClient.GetFromJsonAsync<IEnumerable<TEntity>?>(QueryHelpers.AddQueryString(BaseUri.ToString(), queryParams), cancellationToken);
            return (result, 0); 
        }

        public async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await HttpClient.GetFromJsonAsync<TEntity>(BaseUri + id.ToString(), cancellationToken);

        }

        public async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await HttpClient.PutAsJsonAsync<TEntity>(BaseUri + id.ToString(), entity, cancellationToken);
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


        public string GetTypeName(Type type)
        {
            if (type.IsGenericType)
            {
                string genericArguments = type.GetGenericArguments()
                                    .Select(x => x.Name)
                                    .Aggregate((x1, x2) => $"{x1}, {x2}");
                return ($"{type.Name.Substring(0, type.Name.IndexOf("`"))}"
                     + $"<{genericArguments}>").ToLower();
            }
            return type.Name.ToLower();
        }
    }
}
