using Microsoft.EntityFrameworkCore;
using PerfectFit.Models;

namespace PerfectFit.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Products> Product { get; set; }

    }
}
