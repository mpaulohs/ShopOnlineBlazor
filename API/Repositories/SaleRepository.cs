using Microsoft.Extensions.Logging;
using ShopOnline.API.Models;
using ShopOnline.Library;
using ShopOnline.Library.Models.Documents;
using ShopOnline.Library.Services;
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
