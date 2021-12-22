using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Models;
using ShopOnlinePWA.Library;
using System;

namespace ShopOnlinePWA.API.Repositories
{
    public class SaleStore : EntityStore<DocumentSale, Guid, ApplicationDbContext>
    {
        public SaleStore(ApplicationDbContext RepositoryContext, ILogger<DocumentSale> Logger) : base(RepositoryContext, Logger)
        {
        }
    }
}
