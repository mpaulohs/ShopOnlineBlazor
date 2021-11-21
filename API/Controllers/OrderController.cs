using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Models;
using System;

namespace ShopOnlinePWA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderRepository _repository;

        private ILogger<OrderController> _logger;

        public OrderController(IOrderRepository orderRepository, ILogger<OrderController> loger)
        {
            _repository = orderRepository;
            _logger = loger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var orders = _repository.ReadAll();
                return Ok(orders);

            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Eror inside Get() actoin");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            try
            {
                var order = _repository.Read(id);
                if (order == null)
                {
                    _logger.LogError("Owner witn id {0}, hasn't been found in db.", id);
                    return NotFound();
                }

                return Ok(order);

            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message, "Error inside Get axtion ");
                return StatusCode(500, "Internal server error");
            }

        }


    }
}
