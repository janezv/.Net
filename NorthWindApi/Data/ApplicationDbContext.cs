using Microsoft.EntityFrameworkCore;
using NorthWindApi.Models;

namespace NorthWindApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> products { get; set; }  // Zamenjajte z vašimi entitetami
        public DbSet<Employee> employees { get; set; }  // Zamenjajte z vašimi entitetami
        public DbSet<Customer> customers { get; set; }  // Zamenjajte z vašimi entitetami
    }
}
