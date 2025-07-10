using Microsoft.EntityFrameworkCore;
namespace SimpleAuthorization.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
