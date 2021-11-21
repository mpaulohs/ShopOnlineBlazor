using Microsoft.Extensions.Logging;
using ShopOnlinePWA.API.Migrations;
using ShopOnlinePWA.Library.Documents;
using System;

namespace ShopOnlinePWA.API.Models
{
    public class OrderRepository : RepositoryBase<Order, Guid>, IOrderRepository
    {
        public OrderRepository(AppDbContext RepositoryContext, ILogger<Order> Logger) : base(RepositoryContext, Logger)
        {
        }
    }
}
