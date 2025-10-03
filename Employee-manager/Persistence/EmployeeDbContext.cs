using Employee_manager.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee_manager.Persistence
{
    public class EmployeeDbContext : DbContext
    {
       public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>(o =>
            {
                o.HasKey(j => j.Id);
                // other configurations can be added here

            });
        }

    }
}
