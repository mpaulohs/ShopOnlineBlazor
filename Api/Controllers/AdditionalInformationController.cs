using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.AspNetCore.JsonPatch;

namespace Api.Controllers
{
    public class AdditionalInformationController : GenericController<AdditionalInformation, Guid>
    {
        public AdditionalInformationController(IRepository<AdditionalInformation, Guid> repository, ILogger<AdditionalInformation> loger)
        : base(repository, loger)
        {

        }
    }
}
