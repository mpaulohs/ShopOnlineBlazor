using System;


namespace ShopOnlinePWA.Library
{
    public interface ISaleStore : IEntityStore<DocumentSale, Guid, ApplicationDbContext>
    {
    }
}
