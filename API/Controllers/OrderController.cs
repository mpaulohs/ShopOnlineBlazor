using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Models;
using ShopOnlinePWA.Library;
using System;
using System.Threading.Tasks;

namespace ShopOnlinePWA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IEntityStore<DocumentSale, Guid, ApplicationDbContext> _repository;

        private readonly ILogger<OrderController> _logger;

        public OrderController(IEntityStore<DocumentSale, Guid, ApplicationDbContext> repository, ILogger<OrderController> loger)
        {
            _repository = repository;
            _logger = loger;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _repository.GetByFiltersAsync();

                if (result == null)
                {
                    return StatusCode(404);
                }     
                return StatusCode(200, result);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                {
                    return StatusCode(400, "Bad Request");
                }

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
        public async Task<ActionResult> Post([FromBody] DocumentSale item)
        {
            try
            {
                if (item == null)
                {
                    return StatusCode(400, "Bad Request");
                }

                var result = await _repository.CreateAsync(item);

                return StatusCode(201, result);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] DocumentSale item)
        {
            try
            {
                if (id==Guid.Empty||item==null)
                {
                      return StatusCode(400, "Bad Request");
                }

                var result = await _repository.UpdateAsync(id, item);

                return StatusCode(200, result);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                {
                    return StatusCode(400, "Bad Request");
                }

                var result = await _repository.DeleteByIdAsync(id);

                return StatusCode(200, result);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }



    }
}
