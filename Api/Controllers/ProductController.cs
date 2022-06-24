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

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController<TKey> : ControllerBase
    where TKey: IEquatable<TKey>

    {
        private readonly IRepository<Product<TKey>, TKey> _repository;

        private readonly ILogger<Product<TKey>> _logger;

        public ProductController(IRepository<Product<TKey>, TKey> repository, ILogger<Product<TKey>> loger)
        {
            _repository = repository;
            _logger = loger;
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult> Get(
                [FromQuery] string fields = default,
                [FromQuery] string search = default,
                [FromQuery] string filter = default,
                [FromQuery] string sorts = default,
                [FromQuery] int pageSize = default,
                [FromQuery] int pageCerent = default)
        {
            try
            {
                var result = await _repository.GetAsync(fields, search, filter, sorts, pageSize, pageCerent);

                if (result != null)
                {
                    //Response.Headers.Add("x-pagination", JsonConvert.SerializeObject(result.MetaData));
                    return StatusCode(200, result);
                }
                return StatusCode(404);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] PaginationParameters pagintaionParameters, [FromQuery]
        SearchParameters searchParameters)
        {
            try
            {
                var result = await _repository.GetByFiltersAsync(pagintaionParameters, searchParameters);

                if (result != null)
                {
                    Response.Headers.Add("x-pagination", JsonConvert.SerializeObject(result.MetaData));
                    return StatusCode(200, result);
                }
                return StatusCode(404);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(TKey id)
        {
            try
            {
                var result = await _repository.GetByIdAsync(id);

                if (result != null)
                {
                    return StatusCode(200, result);
                }
                return StatusCode(404);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Product<TKey> item)
        {
            try
            {
                var result = await _repository.CreateAsync(item);

                return StatusCode(201, result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

    }
}

