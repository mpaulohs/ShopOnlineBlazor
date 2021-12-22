using Microsoft.Extensions.Logging;
using System;

namespace ShopOnlinePWA.Library
{
    public class SaleStore : EntityStore<DocumentSale, Guid, ApplicationDbContext>
    {
        public SaleStore(ApplicationDbContext RepositoryContext, ILogger<DocumentSale> Logger) : base(RepositoryContext, Logger)
        {
        }
    }
}
