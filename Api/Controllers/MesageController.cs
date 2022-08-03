using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Documents;
using Shared.Services.Repository;
using Shared.Models.Catalogs;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{

    public class MesageController : GenericController<Mesage<Guid>, Guid>
    {
        public MesageController(IRepository<Mesage<Guid>, Guid> repository, ILogger<Mesage<Guid>> loger) : base(repository, loger)
        {
        }
    }
}