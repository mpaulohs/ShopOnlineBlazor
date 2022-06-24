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
    public class BankAccountController<TKey> : GenericController<BankAccount<TKey>, TKey>
    where TKey: IEquatable<TKey>
    {
        private readonly IRepository<BankAccount<TKey>, TKey> _repository;

        private readonly ILogger<BankAccount<TKey>> _logger;

        public BankAccountController(IRepository<BankAccount<TKey>, TKey> repository, ILogger<BankAccount<TKey>> loger) : base (repository, loger)
        {
            _repository = repository;
            _logger = loger;
        }

    }
}
