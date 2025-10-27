using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
namespace JobSeekerManagement.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; } // optional
    }
}
