using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RazorWS.Models
{
    public class JobDBContext:DbContext
    {
       
            public JobDBContext(DbContextOptions<JobDBContext> options) : base(options) { }

            public DbSet<JobApplication> Jobs { get; set; }

        internal async Task<List<JobApplication>> GetAllJobsAsync()
        {
            throw new NotImplementedException();
        }

        internal async Task<JobApplication> GetJobByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
