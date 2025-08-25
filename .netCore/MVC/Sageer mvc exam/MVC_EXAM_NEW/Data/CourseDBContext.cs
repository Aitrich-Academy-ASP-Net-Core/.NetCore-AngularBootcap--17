using Microsoft.EntityFrameworkCore;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Data
{
    public class CourseDBContext:DbContext
    {
        public CourseDBContext(DbContextOptions<CourseDBContext>options):base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Enrolment> enrolments { get; set; }    
    }
}
