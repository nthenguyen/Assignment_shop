using Microsoft.EntityFrameworkCore;
using Rookie.CustomerSite.Models;

namespace Rookie.CustomerSite.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }
    }
}
