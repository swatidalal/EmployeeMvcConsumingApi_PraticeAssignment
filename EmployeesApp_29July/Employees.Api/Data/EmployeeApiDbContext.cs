using Employees.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Employees.Api.Data
{
    public class EmployeeApiDbContext:DbContext
    {
        public DbSet<Employee> Employee { set; get; }


        public EmployeeApiDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasIndex(Emp => Emp.Email).IsUnique();


        }
    }
}
