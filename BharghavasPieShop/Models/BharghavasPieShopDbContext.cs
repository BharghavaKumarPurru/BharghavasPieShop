using Microsoft.EntityFrameworkCore;

namespace BharghavasPieShop.Models
{
    public class BharghavasPieShopDbContext:DbContext
    {
        public BharghavasPieShopDbContext(DbContextOptions<BharghavasPieShopDbContext>
            options):base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Pie> Pies { get; set; }

    }
}
