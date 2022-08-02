﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using Shared.Models.Identities;
using System;
using System.Threading.Tasks;
using Shared.Services.Request.Pagination;
using Shared.Services.Request.Search;
using Shared.Models;
using System.Collections.Generic;
using System.Linq.Expressions;

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
        [Route("getfilter")]
        public async Task<ActionResult> GetFilter(
                [FromQuery] string fields = default,
                [FromQuery] string search = default,
                [FromQuery] string filter = default,
                [FromQuery] string sorts = default,
                [FromQuery] int pageSize = default,
                [FromQuery] int pageCerent = default)
        {
            try
            {
                Expression<Func<Product<Guid>, bool>>[] filters = default;

                if (filter != default)
                {
                    Expression<Func<Product<Guid>, bool>> filter1 = product => product.Name.Contains(filter);
                    filters = new Expression<Func<Product<Guid>, bool>>[] { filter1 };
                }

                //var filters = new List<Expression<Func<Product<Guid>, bool>>>().ToArray();
                //var explist = new List<Expression<Predicate<Product<Guid>>>>();
                // Expression<Predicate<Product<Guid>>> item = product => product.Name.Contains(filter);
                //var res = explist.Add(item);//.ToArray();



                var result = await _repository.GetAsync(fields, search, filters, sorts, pageSize, pageCerent);

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
        public async Task<ActionResult> Post([FromBody] Product<Guid> item)
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

