using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using Shared.Models.Identities;
using System;
using System.Threading.Tasks;
using Shared.Services.Request.Search;
using Shared.Models;
using Api.Data;
using Microsoft.Extensions.Configuration;
namespace Api.Controllers
{
    public class BankController : GenericController<Bank<Guid>, Bank<Guid>, Guid>
    {
        public BankController(IRepository<Bank<Guid>, Guid> repository, ILogger<Bank<Guid>> loger) : base(repository, loger)
        {
        }
    }
}
