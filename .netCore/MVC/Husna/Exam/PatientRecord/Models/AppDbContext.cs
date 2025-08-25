using Microsoft.EntityFrameworkCore;
namespace PatientRecord.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> patients { get; set; }
    }
}
