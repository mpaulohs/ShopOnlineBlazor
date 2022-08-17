using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using System;
namespace Api.Controllers
{
    public class ProductQuantityController : GenericController<ProductQuantity<Guid>, ProductQuantity<Guid>, Guid>
    {
        public ProductQuantityController(IRepository<ProductQuantity<Guid>, Guid> repository, ILogger<ProductQuantity<Guid>> loger) : base(repository, loger)
        {
        }
    }
}