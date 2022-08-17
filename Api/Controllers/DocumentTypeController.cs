using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Models.Documents;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
namespace Api.Controllers
{
    public class DocumentTypeController : GenericController<DocumentType<Guid>, DocumentType<Guid>, Guid>
    {
        public DocumentTypeController(IRepository<DocumentType<Guid>, Guid> repository, ILogger<DocumentType<Guid>> loger) : base(repository, loger)
        {
        }
    }
}