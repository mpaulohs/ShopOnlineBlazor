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
    public class SubdivisionController : GenericController<Subdivision<Guid>, Guid>
    {
        public SubdivisionController(IRepository<Subdivision<Guid>, Guid> repository, ILogger<Subdivision<Guid>> loger) : base(repository, loger)
        {
        }
    }
}