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

    public class ProductUnitClassifierController : GenericController<ProductUnitClassifier<Guid>, Guid>
    {
        public ProductUnitClassifierController(IRepository<ProductUnitClassifier<Guid>, Guid> repository, ILogger<ProductUnitClassifier<Guid>> loger) : base(repository, loger)
        {
        }
    }
}