using Microsoft.Extensions.Logging;
using ShopOnline.API.Migrations;
using ShopOnline.Library.Models.Documents;
using System;

namespace ShopOnline.API.Services
{
    public class SaleRepository : RepositoryBase<DocumentSale, Guid>
    {
        public SaleRepository(ApplicationDbContext RepositoryContext, ILogger<DocumentSale> Logger) : base(RepositoryContext, Logger)
        {

        }
    }
}
