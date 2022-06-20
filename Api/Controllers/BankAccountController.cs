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
