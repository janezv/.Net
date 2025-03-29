using Microsoft.EntityFrameworkCore;

namespace ApiPluralSight.Data
{
    public class HouseDbContext : DbContext
    {
        public DbSet<HouseEntity> Houses { get; set; } // Property za DbSet

        public HouseDbContext(DbContextOptions<HouseDbContext> options) : base(options) { } // Konstruktor, ki sprejme DbContextOptions

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Po potrebi inicializiraj podatke
            SeedData.Seed(builder);
        }
    }
}
