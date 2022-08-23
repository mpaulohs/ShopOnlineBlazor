using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shared.Models;
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
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            //_requestUri = new Uri(_httpClient.BaseAddress + GetTypeName(typeof(TEntity)));
            _requestUri = new Uri(_httpClient.BaseAddress + "Product");
            Console.WriteLine(typeof(TEntity));
            _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            //BaseUri = new Uri ("api/" + typeof(TEntity).Name.ToLower() + "/");
            //Url = "api/" + typeof(TEntity).Name.ToLower() + "/";
        }
        private Uri _requestUri { get; set; }
        private HttpClient _httpClient { get; set; }
        private readonly JsonSerializerOptions _jsonOptions;
        protected ILogger<TEntity> _logger { get; set; }
        public Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            string serEntity = JsonConvert.SerializeObject(entity);
            StringContent httpContent = new StringContent(serEntity, System.Text.Encoding.UTF8, "application/json");
            var response = _httpClient.PostAsync(_requestUri, httpContent, cancellationToken);

            return null;
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
        public async Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await _httpClient.GetFromJsonAsync<TEntity>(_requestUri + id.ToString(), cancellationToken);
        }
        public async Task<bool> UpdateAsync(TKey id, TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync(_requestUri + id.ToString(), entity, cancellationToken);
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
            return await _httpClient.GetFromJsonAsync<List<TEntity>>(_requestUri, cancellationToken);
        }
        public Task<IEnumerable<TEntity>>? GetAsync(string fields = null, string search = null, Expression<Func<TEntity, bool>>[] filters = null, string sorts = null, int pageSize = 0, int pageCurrent = 0, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<(IEnumerable<TOut>, int)>? GetAsync<TOut>(string search = null, string filter = null, string sorts = null, int take = 0, int skip = 0, CancellationToken cancellationToken = default)
        {
            var queryParams = new Dictionary<string, string>();
            if (take != default)
                queryParams.Add("take", take.ToString());
            if (search != default)
                queryParams.Add("search", search);
            if (filter != default)
                queryParams.Add("filter", filter);
            if (sorts != default)
                queryParams.Add("sorts", sorts);
            if (skip != default)
                queryParams.Add("skip", skip.ToString());
            var uri = QueryHelpers.AddQueryString(_requestUri.OriginalString, queryParams);
            var response = await _httpClient.GetAsync(uri, cancellationToken);
            int count = 0;
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException();
            }
            string header_pagination = response.Headers.GetValues("x-pagination").FirstOrDefault();
            if (header_pagination == null)
            {
                return (null, 0);
            }
            Int32.TryParse(header_pagination, out count);
            if (count == 0)
            {
                return (null, 0);
            }
            var entities = await response.Content.ReadFromJsonAsync<IEnumerable<TOut>>();
            return (entities, count);
        }

        public Task<bool> DeleteAsync(TKey id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TOut>? GetByIdAsync<TOut>(TKey id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
