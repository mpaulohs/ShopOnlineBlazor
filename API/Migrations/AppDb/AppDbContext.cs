using Microsoft.EntityFrameworkCore;

namespace ShopOnlinePWA.API.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}

