using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopOnline.Shared.Models.Catalogs;
using ShopOnline.Shared.Services;
using System;

namespace ShopOnline.API.Controllers
{
    public class AdditionalInformationController : GenericController<AdditionalInformation>
    {
        public AdditionalInformationController(IRepository<AdditionalInformation, Guid> repository, ILogger<AdditionalInformation> loger)
        {

        }

    }
}
