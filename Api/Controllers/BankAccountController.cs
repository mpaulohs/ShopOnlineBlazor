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
    public class BankAccountController : GenericController<BankAccount<Guid>, Guid>
    {
        public BankAccountController(IRepository<BankAccount<Guid>, Guid> repository, ILogger<BankAccount<Guid>> loger) : base(repository, loger)
        {
        }
    }
}
