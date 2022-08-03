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

    public class StorageController : GenericController<Storage<Guid>, Guid>
    {
        public StorageController(IRepository<Storage<Guid>, Guid> repository, ILogger<Storage<Guid>> loger) : base(repository, loger)
        {
        }
    }
}