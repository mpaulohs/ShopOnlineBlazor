using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Services.Request.Pagination;
using Newtonsoft.Json;

namespace Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   public class GenericController<TEntity, TKey> : ControllerBase
             where TEntity : class, IApplicationEntity<TKey>
             where TKey : IEquatable<TKey>
    {
        private readonly IRepository<TEntity, TKey> _repository;
        private readonly ILogger<TEntity> _logger;

        public GenericController(IRepository<TEntity, TKey> repository, ILogger<TEntity> loger)
        {
            _repository = repository;
            _logger = loger;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] PaginationParameters pagintaionParameters)
        {
            try
            {
                var result = await _repository.GetByFiltersAsync(pagintaionParameters);

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
        public async Task<ActionResult> Post([FromBody] TEntity item)
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

