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
    public class ClientContractController : GenericController<ClientContract<Guid>, Guid>
    {
        public ClientContractController(IRepository<ClientContract<Guid>, Guid> repository, ILogger<ClientContract<Guid>> loger) : base(repository, loger)
        {
        }
    }
}