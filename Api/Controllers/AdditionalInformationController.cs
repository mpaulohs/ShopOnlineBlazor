using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Models.Catalogs;
using Shared.Services.Repository;
using System;

namespace Api.Controllers
{
    public class AdditionalInformationController : GenericController<AdditionalInformation>
    {
        public AdditionalInformationController(IRepository<AdditionalInformation, Guid> repository, ILogger<AdditionalInformation> loger)
        {

        }

    }
}
