using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Models;
using ShopOnlinePWA.Library;
using System;

namespace ShopOnlinePWA.API.Repositories
{
    public class SaleRepository : RepositoryBase<DocumentSale, Guid, ApplicationDbContext>
    {
        public SaleRepository(ApplicationDbContext RepositoryContext, ILogger<DocumentSale> Logger) : base(RepositoryContext, Logger)
        {
        }
    }
}
