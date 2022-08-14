using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shared.Models;
using Shared.Services.Request.Pagination;
using Shared.Services.Request.Search;
using System.Linq.Expressions;
using System.Net.Http.Json;
using System.Text.Json;
namespace Shared.Services.Repository
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
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            //BaseUri = new Uri ("api/" + typeof(TEntity).Name.ToLower() + "/");
            //Url = "api/" + typeof(TEntity).Name.ToLower() + "/";
        }
        protected Uri RequestUri { get; set; }
        protected HttpClient HttpClient { get; private set; }
        private readonly JsonSerializerOptions _options;
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
        public async Task<PaginationList<TEntity>> GetByFiltersAsync(PaginationParameters paginationParameters, SearchParameters searchParameters = default, CancellationToken cancellationToken = default, Expression<Func<TEntity, bool>>[] filters = default)
        {
            var queryParams = new Dictionary<string, string>
            {
                ["curentPage"] = paginationParameters.curentPage.ToString(),
                ["searchTerm"] = searchParameters.SearchTerm == null ? "" : searchParameters.SearchTerm
            };
            var uri = QueryHelpers.AddQueryString(RequestUri.OriginalString, queryParams);
            var response = await HttpClient.GetAsync(uri, cancellationToken);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            string contextHeaderPagination = response.Headers.GetValues("x-pagination").FirstOrDefault();
            var PaginationList = new PaginationList<TEntity>
            {
                Entities = JsonConvert.DeserializeObject<IEnumerable<TEntity>>(content),
                MetaData = JsonConvert.DeserializeObject<PaginationMetaData>(contextHeaderPagination)
            };
            return PaginationList;
        }
        public async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await HttpClient.GetFromJsonAsync<TEntity>(RequestUri + id.ToString(), cancellationToken);
        }
        public async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await HttpClient.PutAsJsonAsync(RequestUri + id.ToString(), entity, cancellationToken);
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
        public async Task<List<TEntity>>? GetAsync(string fields = null, string search = null, string filter = null, string sorts = null, int pageSize = 0, int pageCurrent = 0, CancellationToken cancellationToken = default)
        {
            return await HttpClient.GetFromJsonAsync<List<TEntity>>(RequestUri, cancellationToken);
        }
        public Task<IEnumerable<TEntity>>? GetAsync(string fields = null, string search = null, Expression<Func<TEntity, bool>>[] filters = null, string sorts = null, int pageSize = 0, int pageCurrent = 0, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
