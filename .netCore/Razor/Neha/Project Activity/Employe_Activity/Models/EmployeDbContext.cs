using Microsoft.EntityFrameworkCore;
namespace Employe_Activity.Models
{
    public class EmployeDbContext:DbContext
    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employe> Employes { get; set; }
    }
}
