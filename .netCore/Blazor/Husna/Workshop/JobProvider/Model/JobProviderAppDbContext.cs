using Microsoft.EntityFrameworkCore;
namespace JobProvider.Model
{
    public class JobProviderAppDbContext:DbContext
    {
        public JobProviderAppDbContext(DbContextOptions<JobProviderAppDbContext> options) :
            base(options) { }
        public DbSet<JobProviderr> JobProviders { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
