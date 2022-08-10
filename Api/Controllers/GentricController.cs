﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Services.Request.Pagination;
using Newtonsoft.Json;
using Microsoft.AspNetCore.JsonPatch;
using System.Linq.Expressions;
using System.Linq;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using Shared.Models.Dtos;

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
               [FromQuery] string fields = default,
               [FromQuery] string search = default,
               [FromQuery] string filter = default,
               [FromQuery] string orderby = default,
               [FromQuery] int skip = default,
               [FromQuery] int take = default)
        {
            try
            {
                var response = _repository.GetAsync<ProductDTO<Guid>>(search, filter, orderby, take, skip);

                if (response != null)
                {
                    //ToDo: "create extra information in response header"
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

        // [HttpGet]
        // [Route("old")]
        // public async Task<ActionResult> Get(
        //        [FromQuery] string fields = default,
        //        [FromQuery] string search = default,
        //        [FromQuery] string filter = default,
        //        [FromQuery] string sorts = default,
        //        [FromQuery] string pageSize = default,
        //        [FromQuery] string curentPage = default)
        // {
        //     try
        //     {
        //         //string filter = default;

        //         Expression<Func<TEntity, bool>>[] filters = default;

        //         //ToDo update filters

        //         //Search
        //         if (search != default)
        //         {
        //             var filtersList = new List<Expression<Func<TEntity, bool>>>();
        //             Expression<Func<TEntity, bool>> searchExpression = default;
        //             if (fields != default)
        //             {
        //                 var properties = fields.Split(",", StringSplitOptions.RemoveEmptyEntries);
        //                 foreach (var propertyName in properties)
        //                 {
        //                     try
        //                     {
        //                         var strSearchExpression = string.Format("entity => entity.{0}.Contains(\"{1}\")", propertyName, search);
        //                         var searchExpressionNew = FilterExtensions.ToExpression<TEntity, TKey>(strSearchExpression);
        //                         if (searchExpression == default)
        //                         {
        //                             searchExpression = searchExpressionNew;
        //                         }
        //                         else
        //                         {
        //                             searchExpression = searchExpression.OrElse<TEntity>(searchExpressionNew);
        //                         }
        //                     }
        //                     catch (System.Exception exception)
        //                     {
        //                         _logger.LogError(exception.Message);
        //                         continue;
        //                     }
        //                 }
        //             }
        //             else
        //             {
        //                 var properties = typeof(TEntity).GetProperties();
        //                 var x = typeof(TEntity).GetProperties().Select(propertyInfo => propertyInfo.Name).ToArray();
        //                 foreach (var property in properties)
        //                 {
        //                     try
        //                     {
        //                         var strSearchExpression = string.Format("entity => entity.{0}.Contains(\"{1}\")", property.Name, search);
        //                         var searchExpressionNew = FilterExtensions.ToExpression<TEntity, TKey>(strSearchExpression);
        //                         if (searchExpression == default)
        //                         {
        //                             searchExpression = searchExpressionNew;
        //                         }
        //                         else
        //                         {
        //                             searchExpression = searchExpression.OrElse<TEntity>(searchExpressionNew);
        //                         }
        //                     }
        //                     catch (System.Exception exception)
        //                     {
        //                         _logger.LogError(exception.Message);
        //                         continue;
        //                     }
        //                 }
        //             }
        //             filtersList.Add(searchExpression);
        //             if (filtersList.Count > 0)
        //             {
        //                 filters = filtersList.ToArray();
        //             }
        //         }

        //         var response = await _repository.GetAsync(fields, search, filters, sorts, pageSize, curentPage);

        //         if (response != null)
        //         {
        //             //ToDo: "create extra information in response header"
        //             //Response.Headers.Add("x-pagination", JsonConvert.SerializeObject(response.MetaData));
        //             return StatusCode(200, response);
        //         }
        //         return StatusCode(404);
        //     }
        //     catch (Exception exception)
        //     {
        //         _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
        //         return StatusCode(500, "Internal server error");
        //     }
        // }

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

