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
    public class PriceTypeController : GenericController<PriceType<Guid>, Guid>
    {
        public PriceTypeController(IRepository<PriceType<Guid>, Guid> repository, ILogger<PriceType<Guid>> loger) : base(repository, loger)
        {
        }
    }
}