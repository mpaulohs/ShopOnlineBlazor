using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SharedLib.Models.Catalogs;
using SharedLib.Services.Repository;
using SharedLib.Models.Documents;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : GenericController<BankAccount>
    {
        private readonly IRepository<BankAccount, Guid> _repository;

        private readonly ILogger<BankAccount> _logger;

        public BankAccountController(IRepository<BankAccount, Guid> repository, ILogger<BankAccount> loger) : base (repository, loger)
        {
            _repository = repository;
            _logger = loger;
        }

    }
}
