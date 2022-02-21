using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shared.Views.Pagination;
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
            RequestUri = new Uri(HttpClient.BaseAddress + GetTypeName(typeof(TEntity)));
            Console.WriteLine(typeof(TEntity));
            //BaseUri = new Uri ("api/" + typeof(TEntity).Name.ToLower() + "/");
            //Url = "api/" + typeof(TEntity).Name.ToLower() + "/";
        }

        protected Uri RequestUri { get; set; }
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


        public async Task<(IEnumerable<TEntity> entities, PaginationEntitiesMetaData paginationEntitiesMetaData)?> GetByFiltersAsync(CancellationToken cancellationToken = default, int limit = default, int offset = default, params Expression<Func<TEntity, bool>>[] filters)
        {

            var queryParams = new Dictionary<string, string>
            {
                ["limit"] = limit.ToString(),
                ["offset"] = offset.ToString(),
            };


            PaginationEntitiesMetaData? paginationEntitiesMetaData = null;

            var response = await HttpClient.GetAsync(QueryHelpers.AddQueryString(RequestUri.OriginalString, queryParams), cancellationToken);

            IEnumerable<TEntity>? entities = JsonConvert.DeserializeObject<IEnumerable<TEntity>>(await response.Content.ReadAsStringAsync());

            paginationEntitiesMetaData = JsonConvert.DeserializeObject<PaginationEntitiesMetaData>(response.Headers.GetValues("x-pagination").FirstOrDefault());

            if (paginationEntitiesMetaData == null)
            {
                paginationEntitiesMetaData = new PaginationEntitiesMetaData(0, limit, offset);
            }

            return (entities, paginationEntitiesMetaData);
        }

        public async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await HttpClient.GetFromJsonAsync<TEntity>(RequestUri + id.ToString(), cancellationToken);

        }

        public async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await HttpClient.PutAsJsonAsync<TEntity>(RequestUri + id.ToString(), entity, cancellationToken);
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
