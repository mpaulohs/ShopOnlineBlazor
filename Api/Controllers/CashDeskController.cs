using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using Shared.Models.Documents;
using System;
using System.Threading.Tasks;
using Shared.Services.Request.Pagination;
using Newtonsoft.Json;

namespace Api.Controllers
{
    public class CashDeskController : GenericController<CashDesk<Guid>, Guid>
    {
        public CashDeskController(IRepository<CashDesk<Guid>, Guid> repository, ILogger<CashDesk<Guid>> loger) : base(repository, loger)
        {
        }
    }
}