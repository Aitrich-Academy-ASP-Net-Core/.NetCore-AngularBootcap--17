using Microsoft.EntityFrameworkCore;

namespace Mini_project.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<CompanyMember> CompanyMembers { get; set; }

    }
}
