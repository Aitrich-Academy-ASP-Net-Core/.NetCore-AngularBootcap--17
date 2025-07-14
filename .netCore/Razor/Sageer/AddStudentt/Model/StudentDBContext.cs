using Microsoft.EntityFrameworkCore;

namespace AddStudentt.Model
{
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }

    }
}
