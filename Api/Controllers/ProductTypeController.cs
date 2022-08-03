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

    public class ProductTypeController : GenericController<ProductType<Guid>, Guid>
    {
        public ProductTypeController(IRepository<ProductType<Guid>, Guid> repository, ILogger<ProductType<Guid>> loger) : base(repository, loger)
        {
        }
    }
}