using Microsoft.EntityFrameworkCore;

namespace Workshop.Models
{
    public class JobDbContext:DbContext
    {
        public JobDbContext(DbContextOptions<JobDbContext>options)
            : base(options)
        {

        }
        public DbSet<Job> Jobs { get; set; }
    }
}
