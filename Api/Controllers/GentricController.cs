using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Services.Request.Pagination;
using Newtonsoft.Json;
using Microsoft.AspNetCore.JsonPatch;
using System.Linq.Expressions;
using Swashbuckle.AspNetCore.Annotations;

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
        public async Task<ActionResult> Get(
               [FromQuery] string fields = default,
               [FromQuery] string search = default,
               [FromQuery] string filter = default,
               [FromQuery] string sorts = default,
               [FromQuery] int pageSize = default,
               [FromQuery] int curentPage = default)
        {
            try
            {

                Expression<Func<TEntity, bool>>[] filters = default;

                if (filter != default && search != default)
                {
                    Expression<Func<TEntity, bool>> filterExpression = entity => entity.Id.Equals(filter);
                    filters = new[] { filterExpression };
                }

                var response = await _repository.GetAsync(fields, search, filters, sorts, pageSize, curentPage);

                if (response != null)
                {
                    //ToDo "create extra information in response header"
                    //Response.Headers.Add("x-pagination", JsonConvert.SerializeObject(response.MetaData));
                    return StatusCode(200, response);
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
        public async Task<ActionResult> Get([FromRoute] TKey id)
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
        public async Task<ActionResult> Post([FromBody] TEntity entity)
        {
            try
            {
                var result = await _repository.CreateAsync(entity);

                return StatusCode(201, result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromRoute] TKey id, [FromBody] JsonPatchDocument entity)
        {
            try
            {
                var result = await _repository.UpdatePartyalAsync(id, entity);
                return StatusCode(201, result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(TKey id)
        {
            try
            {
                var response = await _repository.DeleteByIdAsync(id);

                if (response == true)
                {
                    return StatusCode(200, response);
                }
                return StatusCode(404);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

