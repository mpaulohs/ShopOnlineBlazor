using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using Shared.Models.Identities;
using System;
using System.Threading.Tasks;
using Shared.Services.Request.Pagination;
using Shared.Services.Request.Search;
using Shared.Models;

namespace Api.Controllers
{
    public interface IApplicationController<TEntity, TKey>
     where TEntity : class, IApplicationEntity<TKey>
     where TKey : IEquatable<TKey>
    {

        public Task<ActionResult> Get([FromQuery] PaginationParameters pagintaionParameters, [FromQuery] SearchParameters searchParameters);

        public Task<ActionResult> Get(
                [FromQuery] string fields = default,
                [FromQuery] string search = default,
                [FromQuery] string filter = default,
                [FromQuery] string sorts = default,
                [FromQuery] int pageSize = default,
                [FromQuery] int pageCerent = default);


        public Task<ActionResult> Get(TKey id);

        public Task<ActionResult> Post([FromBody] TEntity item);

    }
}