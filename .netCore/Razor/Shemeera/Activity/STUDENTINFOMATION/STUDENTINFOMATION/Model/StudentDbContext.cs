using Microsoft.EntityFrameworkCore;

namespace STUDENTINFOMATION.Model
{
    public class StudentDbContext:DbContext
    {


        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }


        public DbSet<Student> Students { get; set; }



    }
}
