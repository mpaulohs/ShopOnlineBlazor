using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Documents;
using Shared.Services.Repository;
using Shared.Models.Catalogs;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{

    public class DocumentPaymentController : GenericController<DocumentPayment<Guid>, Guid>
    {
        public DocumentPaymentController(IRepository<DocumentPayment<Guid>, Guid> repository, ILogger<DocumentPayment<Guid>> loger) : base(repository, loger)
        {
        }
    }
}