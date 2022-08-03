using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using Shared.Models.Documents;
using System;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers
{

    public class ProductQualityController : GenericController<ProductQuality<Guid>, Guid>
    {
        public ProductQualityController(IRepository<ProductQuality<Guid>, Guid> repository, ILogger<ProductQuality<Guid>> loger) : base(repository, loger)
        {
        }
    }
}