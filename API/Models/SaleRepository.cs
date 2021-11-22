using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations;
using ShopOnlinePWA.Library.Documents;
using System;

namespace ShopOnlinePWA.API.Models
{
    public class SaleRepository : RepositoryBase<Sale, Guid>, ISaleRepository
    {
        public SaleRepository(AppDbContext RepositoryContext, ILogger<Sale> Logger) : base(RepositoryContext, Logger)
        {
        }
    }
}
