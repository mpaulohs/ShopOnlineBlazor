using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Documents;
using Shared.Models.Dtos;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
namespace Api.Controllers
{
    public class DocumentSaleController : GenericController<DocumentsListDTO<Guid>, DocumentSale<Guid>, Guid>
    {
        public DocumentSaleController(IRepository<DocumentSale<Guid>, Guid> repository, ILogger<DocumentSale<Guid>> loger) : base(repository, loger)
        {
        }
    }
}