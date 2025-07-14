using Microsoft.EntityFrameworkCore;
namespace RazorExamm.Models
{
    public class BookDBContext:DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext>options):base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
