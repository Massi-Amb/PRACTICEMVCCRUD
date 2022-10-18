using Microsoft.EntityFrameworkCore;
using PRATICEMVCCRUD.Models.Domain;

namespace PRATICEMVCCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
