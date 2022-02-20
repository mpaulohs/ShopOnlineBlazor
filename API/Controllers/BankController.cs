using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Models.Documents;
using ShopOnline.Shared.Services;
using System;
using System.Threading.Tasks;

namespace ShopOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : GenericController<AdditionalInformation>
    {
        public BankController(IRepository<Bank, Guid> repository, ILogger<Bank> loger)
        {
        }

    }
}
