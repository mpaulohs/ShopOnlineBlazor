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
    public class ProductSerieController : GenericController<ProductSerie<Guid>, ProductSerie<Guid>, Guid>
    {
        public ProductSerieController(IRepository<ProductSerie<Guid>, Guid> repository, ILogger<ProductSerie<Guid>> loger) : base(repository, loger)
        {
        }
    }
}