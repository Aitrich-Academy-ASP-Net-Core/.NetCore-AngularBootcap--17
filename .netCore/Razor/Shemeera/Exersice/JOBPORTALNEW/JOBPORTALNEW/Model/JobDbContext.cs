using Microsoft.EntityFrameworkCore;

namespace JOBPORTALNEW.Model
{
    public class JobDbContext:DbContext
    {

        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Applied> AppliedJobs { get; set; }
    }




}
