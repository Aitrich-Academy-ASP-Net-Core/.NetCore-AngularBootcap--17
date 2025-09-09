using Microsoft.EntityFrameworkCore;

namespace JobPortal.Model
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }



    }
}
