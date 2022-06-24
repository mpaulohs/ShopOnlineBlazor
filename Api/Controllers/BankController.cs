
using Microsoft.AspNetCore.Mvc;
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



namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        protected IApplicationController<Bank<Guid>, Guid> Controller;
        public BankController(IApplicationController<Bank<Guid>, Guid> controller)
        {
            this.Controller = controller;
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult> Get([FromQuery] PaginationParameters pagintaionParameters, [FromQuery]
        SearchParameters searchParameters)
        {
            return await Controller.Get(pagintaionParameters, searchParameters);
        }

    }
}
