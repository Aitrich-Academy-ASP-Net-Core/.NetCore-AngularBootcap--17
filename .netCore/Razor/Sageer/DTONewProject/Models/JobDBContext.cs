using Microsoft.EntityFrameworkCore;

namespace DTONewProject.Models
{
    public class JobDBContext:DbContext
    {
        public JobDBContext(DbContextOptions<JobDBContext>options)
            : base(options)
        {

        }
        public DbSet<Job> Jobs { get; set; }
    }
}
