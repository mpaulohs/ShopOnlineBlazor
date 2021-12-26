using Microsoft.Extensions.Logging;
using ShopOnline.API.Models;
using ShopOnline.Library;
using System;

namespace ShopOnline.API.Repositories
{
    public class SaleRepository : RepositoryBase<DocumentSale, Guid, ApplicationDbContext>
    {
        public SaleRepository(ApplicationDbContext RepositoryContext, ILogger<DocumentSale> Logger) : base(RepositoryContext, Logger)
        {
            
        }
    }
}
