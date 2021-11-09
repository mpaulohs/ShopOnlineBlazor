using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopOnlinePWA.Library.Catalogs;

namespace ShopOnlinePWA.API.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }



    }
}

