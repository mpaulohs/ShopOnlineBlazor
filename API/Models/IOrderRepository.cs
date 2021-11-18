using ShopOnlinePWA.Library.Documents;
using ShopOnlinePWA.Library.Repositories;
using System;

namespace ShopOnlinePWA.API.Models
{
    public interface IOrderRepository : IRepositoryBase<Order, Guid> 
    {
    }
}
