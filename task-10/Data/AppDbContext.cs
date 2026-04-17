using Microsoft.EntityFrameworkCore;
namespace task_10.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Product{ get; set; }
    }
}