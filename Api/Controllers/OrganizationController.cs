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
    public class OrganizationController : GenericController<Organization<Guid>, Organization<Guid>, Guid>
    {
        public OrganizationController(IRepository<Organization<Guid>, Guid> repository, ILogger<Organization<Guid>> loger) : base(repository, loger)
        {
        }
    }
}