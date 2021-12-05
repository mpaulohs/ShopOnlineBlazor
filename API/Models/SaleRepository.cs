using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations;
using ShopOnlinePWA.Library;
using System;

namespace ShopOnlinePWA.API.Models
{
    public class SaleRepository : RepositoryBase<DocumentSale, Guid>, ISaleRepository
    {
        public SaleRepository(AppDbContext RepositoryContext, ILogger<DocumentSale> Logger) : base(RepositoryContext, Logger)
        {
        }
    }
}
