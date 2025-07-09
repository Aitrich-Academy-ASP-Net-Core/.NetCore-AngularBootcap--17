using Microsoft.EntityFrameworkCore;
namespace LibraryManagement.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Book> Books { get; set; }
    }
}
