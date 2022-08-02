using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.AspNetCore.JsonPatch;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product<Guid>, Guid> _repository;
        private readonly ILogger<Product<Guid>> _logger;
        public ProductController(IRepository<Product<Guid>, Guid> repository, ILogger<Product<Guid>> loger)
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
                Expression<Func<Product<Guid>, bool>>[] filters = default;

                if (filter != default && search != default)
                {
                    Expression<Func<Product<Guid>, bool>> filterExpression = product => product.Name.Contains(filter);
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
        public async Task<ActionResult> Get([FromRoute] Guid id)
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
        public async Task<ActionResult> Post([FromBody] Product<Guid> entity)
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
        public async Task<ActionResult> Put([FromRoute] Guid id, [FromBody] JsonPatchDocument entity)
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
        public async Task<ActionResult> Delete(Guid id)
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

