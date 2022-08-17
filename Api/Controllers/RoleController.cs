using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Identities;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
namespace Api.Controllers
{
    public class RoleController : GenericController<Role<Guid>, Role<Guid>, Guid>
    {
        public RoleController(IRepository<Role<Guid>, Guid> repository, ILogger<Role<Guid>> loger) : base(repository, loger)
        {
        }
    }
}