using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using Shared.Models.Documents;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly IRepository<Storage, Guid> _repository;

        private readonly ILogger<StorageController> _logger;

        public StorageController(IRepository<Storage, Guid> repository, ILogger<StorageController> loger)
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
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult> Get([FromRoute] Guid id)
        {
            try
            {
                if (id == Guid.Empty)
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }

                var result = await _repository.GetByIdAsync(id);

                if (result != null)
                {
                    return StatusCode(StatusCodes.Status200OK, result);
                }

                return StatusCode(StatusCodes.Status404NotFound);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Storage entity)
        {
            try
            {
                if (entity == null)
                {
                    return StatusCode(400, "Bad Request");
                }

                var result = await _repository.CreateAsync(entity);

                return StatusCode(201, result);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpPut("{id:Guid}")]
        public async Task<ActionResult> Put([FromRoute] Guid id, [FromBody] Storage entity)
        {
            try
            {
                if (id == Guid.Empty || entity == null)
                {
                    return StatusCode(400, "Bad Request");
                }

                var result = await _repository.UpdateAsync(id, entity);

                return StatusCode(200, result);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }


        [HttpPatch("{id:Guid}")]
        public async Task<ActionResult> Patch([FromRoute] Guid id, [FromBody] JsonPatchDocument entity)
        {
            try
            {
                if (id == Guid.Empty || entity == null)
                {
                    return StatusCode(400, "Bad Request");
                }

                var result = await _repository.UpdatePartyalAsync(id, entity);

                return StatusCode(200, result);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "An exception on {0}", System.Reflection.MethodBase.GetCurrentMethod().Name);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> Delete([FromRoute] Guid id)
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
