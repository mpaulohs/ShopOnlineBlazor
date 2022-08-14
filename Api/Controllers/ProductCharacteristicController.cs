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
    public class ProductCharacteristicController : GenericController<ProductCharacteristic<Guid>, Guid>
    {
        public ProductCharacteristicController(IRepository<ProductCharacteristic<Guid>, Guid> repository, ILogger<ProductCharacteristic<Guid>> loger) : base(repository, loger)
        {
        }
    }
}