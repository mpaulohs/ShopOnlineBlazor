using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Identities;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
namespace Api.Controllers
{
    public class UserController : GenericController<User<Guid>, User<Guid>, Guid>
    {
        public UserController(IRepository<User<Guid>, Guid> repository, ILogger<User<Guid>> loger) : base(repository, loger)
        {
        }
    }
}