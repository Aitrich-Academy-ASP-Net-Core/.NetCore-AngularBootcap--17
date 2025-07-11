using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace RazorExerciseNew.Models
{
    namespace RazorWS.Models
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Job> Jobs { get; set; }
            public DbSet<Application> Applications { get; set; }
        }
    }
}
}