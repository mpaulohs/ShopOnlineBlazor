using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using Shared.Models.Documents;
using System;
using Newtonsoft.Json;
namespace Api.Controllers
{
    public class ClientContactInformationController : GenericController<ClientContactInformation<Guid>, ClientContactInformation<Guid>, Guid>
    {
        public ClientContactInformationController(IRepository<ClientContactInformation<Guid>, Guid> repository, ILogger<ClientContactInformation<Guid>> loger) : base(repository, loger)
        {
        }
    }
}