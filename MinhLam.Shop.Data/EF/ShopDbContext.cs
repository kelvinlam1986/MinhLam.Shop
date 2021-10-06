using Microsoft.EntityFrameworkCore;
using MinhLam.Shop.Data.Entities;

namespace MinhLam.Shop.Data.EF
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
