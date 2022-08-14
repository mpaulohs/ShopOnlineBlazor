using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.AspNetCore.JsonPatch;
using Shared.Models.Dtos;
namespace Api.Controllers
{
    public class ProductController : GenericController<ProductDTO<Guid>, Product<Guid>, Guid>
    {
        public ProductController(IRepository<Product<Guid>, Guid> repository, ILogger<Product<Guid>> loger) : base(repository, loger)
        {
        }
    }
}