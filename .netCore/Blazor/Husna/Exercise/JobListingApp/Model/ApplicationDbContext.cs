using Microsoft.EntityFrameworkCore;
namespace JobListingApp.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):
            base(options)
        {

        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
    }
}
