using Microsoft.EntityFrameworkCore;

namespace MVA_CORE.Model
{
    public class ProductContext : DbContext

    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
{
        }

        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products { get; set; }

      
    }
}
