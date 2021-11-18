using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations.AppIdentityDb;
using ShopOnlinePWA.Library.Documents;
using System;

namespace ShopOnlinePWA.API.Models
{
    public class OrderRepository : RepositoryBase<Order, Guid>, IOrderRepository
    {
        public OrderRepository(AppDbContext RepositoryContext, ILogger Logger) : base(RepositoryContext, Logger)
        {
        }
    }
}
