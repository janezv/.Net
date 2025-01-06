using Microsoft.EntityFrameworkCore;

namespace NorthWindApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

      //  public DbSet<YourEntity> YourEntities { get; set; }  // Zamenjajte z vašimi entitetami
    }
}
