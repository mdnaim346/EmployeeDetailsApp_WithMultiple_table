using EmployeeDetailsApp_WithMultiple_table.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetailsApp_WithMultiple_table.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
       public DbSet<Department> Departments { get; set; }
    }
}
