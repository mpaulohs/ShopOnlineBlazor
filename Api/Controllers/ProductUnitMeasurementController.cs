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
    public class ProductUnitMeasurementController : GenericController<ProductUnitMeasurement<Guid>, ProductUnitMeasurement<Guid>, Guid>
    {
        public ProductUnitMeasurementController(IRepository<ProductUnitMeasurement<Guid>, Guid> repository, ILogger<ProductUnitMeasurement<Guid>> loger) : base(repository, loger)
        {
        }
    }
}