using Microsoft.EntityFrameworkCore;
using ShopApp1.Entities;

namespace ShopApp1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
        
    }
}
