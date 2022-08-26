using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Models.Dtos;
using System.Linq.Expressions;
using Shared.Models.Catalogs;
namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TOut, TEntity, TKey> : ControllerBase
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
               // [FromQuery] string fields = default, //ToDo try to implement "create from any entity type"
               [FromQuery] string search = default,
               [FromQuery] string filter = default,
               [FromQuery] string orderby = default,
               [FromQuery] int skip = default,
               [FromQuery] int take = default)
        {
            try
            {
                var response = _repository.GetAsync<TOut>(search, filter, orderby, take, skip);
                if (response.Status == TaskStatus.RanToCompletion)
                {
                    var items = response?.Result.Item1;
                    var count = response?.Result.Item2;
                    Response.Headers.Add("x-pagination", count.ToString());
                    return StatusCode(200, items);
                }
                if (response.Status == TaskStatus.Canceled)
                {
                    return StatusCode(404);
                }
                if (response.Status == TaskStatus.Faulted)
                {
                    return StatusCode(500, "Internal server error");
                }
                return StatusCode(500, "Internal server error");



                // if (response?.Result != null)
                // {
                //     //ToDo: "create extra information in response header"
                //     //Response.Headers.Add("x-pagination", JsonConvert.SerializeObject(response.MetaData));

                //     return StatusCode(200, response.Result);
                // }
                // return StatusCode(404);
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
        //ToDo implement put metod
        // [HttpPut("{id}")]
        // public async Task<ActionResult> Put([FromRoute] TKey id, [FromBody] JsonPatchDocument entity)
        // {
        //     try
        //     {
        //         var result = await _repository.UpdatePartyalAsync(id, entity);
        //         return StatusCode(201, result);
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
        //         return StatusCode(500, "Internal server error");
        //     }
        // }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(TKey id)
        {
            try
            {
                var response = await _repository.DeleteAsync(id);
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
