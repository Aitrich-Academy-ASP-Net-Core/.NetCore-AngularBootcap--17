using Employee.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Employeedata> Employees { get; set; }

    }
}
