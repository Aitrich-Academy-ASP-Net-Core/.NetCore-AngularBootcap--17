using Microsoft.EntityFrameworkCore;

namespace Exam.Models
{
    public class HospitalDbContext:DbContext
    {

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
        : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }

}

