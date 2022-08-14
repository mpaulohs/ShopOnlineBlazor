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
    public class CurrencyController : GenericController<Currency<Guid>, Guid>
    {
        public CurrencyController(IRepository<Currency<Guid>, Guid> repository, ILogger<Currency<Guid>> loger) : base(repository, loger)
        {
        }
    }
}