
using Microsoft.EntityFrameworkCore;
using System;
namespace razorrpagesneww.models
{
    public class StudentDBContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }
           
    }
}
