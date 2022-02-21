using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Identities;
using ShopOnline.Shared.Services;
using System;
using System.Threading.Tasks;

namespace ShopOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product, Guid> _repository;

        private readonly ILogger<UserController> _logger;

        public ProductController(IRepository<Product, Guid> repository, ILogger<UserController> loger)
        {
            _repository = repository;
            _logger = loger;
        }

        //[HttpGet]
        //public async Task<ActionResult> Get()
        //{
        //    try
        //    {
        //        var result = await _repository.GetByFiltersAsync();

        //        if (result != null)
        //        {
        //            return StatusCode(200, result);
        //        }
        //        return StatusCode(404);
        //    }
        //    catch (Exception exception)
        //    {

        //        _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
        //        return StatusCode(500, "Internal server error");
        //    }
        //}

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] int limit, int offset)
        {
            try
            {
                var result = await _repository.GetByFiltersAsync(limit:limit, offset:offset);

                if (result != null)
                {
                    var PaginationEntitiesMetaData = result.Value.paginationEntitiesMetaData;
                

                    Response.Headers.Add("x-pagination", JsonConvert.SerializeObject(PaginationEntitiesMetaData));
                    return StatusCode(200, result.Value.Item1);

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
        public async Task<ActionResult> Get(Guid id)
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
        public async Task<ActionResult> Post([FromBody] Product item)
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

