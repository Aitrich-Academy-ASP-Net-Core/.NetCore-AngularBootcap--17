using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JOBMANAGEMENT.Model
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Jobs> Jobs { get; set; }




    }
}
