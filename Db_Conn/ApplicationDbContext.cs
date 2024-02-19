using Microsoft.EntityFrameworkCore;
using TaskWebApplication.Models;

namespace TaskWebApplication.Db_Conn
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Employee_Salary> Employee_Salaries { get; set; }

    }
}
