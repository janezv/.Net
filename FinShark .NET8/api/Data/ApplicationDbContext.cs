using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            
        }

        public DbSet<Stock> stocks { get; set; }
        public DbSet<Comment> comments { get; set; }

    }
}
