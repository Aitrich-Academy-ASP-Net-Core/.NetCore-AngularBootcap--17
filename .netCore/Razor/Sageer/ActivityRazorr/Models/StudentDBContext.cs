using Microsoft.EntityFrameworkCore;
namespace ActivityRazorr.Models
{
    public class StudentDBContext:DbContext
    {
        internal object Users;

        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
