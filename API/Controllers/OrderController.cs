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
        private ISaleRepository _repository;

        private ILogger<OrderController> _logger;

        public OrderController(ISaleRepository repository, ILogger<OrderController> loger)
        {
            _repository = repository;
            _logger = loger;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var items = await _repository.Read();
                return Ok(items);

            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Eror inside Get() actoin");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                var item = await _repository.Read(id);
                if (item == null)
                {
                    _logger.LogError("Can't fount Entity witn id {0}", id);
                    return NotFound();
                }
                return Ok(item);

            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message, "Error inside Get axtion");
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post(DocumentSale item)
        {
            try
            {
                var result = await _repository.Create(item);
                if (result == null)
                {
                    _logger.LogError("Cannot add the {0} to db ", item);
                    return NotFound();
                }

                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "Error inside Get axtion ");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
