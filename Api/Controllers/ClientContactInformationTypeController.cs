using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
namespace Api.Controllers
{
    public class ClientContactInformationTypeTypeController : GenericController<ClientContactInformationType<Guid>, ClientContactInformationType<Guid>, Guid>
    {
        public ClientContactInformationTypeTypeController(IRepository<ClientContactInformationType<Guid>, Guid> repository, ILogger<ClientContactInformationType<Guid>> loger) : base(repository, loger)
        {
        }
    }
}