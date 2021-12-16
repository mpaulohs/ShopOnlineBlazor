﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Models;
using ShopOnlinePWA.Library;
using System;

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
        public ActionResult Get()
        {
            try
            {
                var items = _repository.ReadAll();
                return Ok(items);

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
                var item = _repository.Read(id);
                if (item == null)
                {
                    _logger.LogError("Owner witn id {0}, hasn't been found in db.", id);
                    return NotFound();
                }

                return Ok(item);

            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message, "Error inside Get axtion ");
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPost]
        public ActionResult Post(DocumentSale item)
        {
            try
            {
                var result = _repository.Create(item);
                if (result == null)
                {
                    _logger.LogError("Cannot add the {0} to db", item);
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
