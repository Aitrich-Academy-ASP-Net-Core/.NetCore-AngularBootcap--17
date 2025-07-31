using Microsoft.EntityFrameworkCore;
namespace BlzrAuthorization.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Userss { get; set; }
    }
}
