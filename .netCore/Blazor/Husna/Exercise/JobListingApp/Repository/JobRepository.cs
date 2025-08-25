using JobListingApp.Interface;
using JobListingApp.Model;
using Microsoft.EntityFrameworkCore;

namespace JobListingApp.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly ApplicationDbContext _context;

        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await _context.Jobs.FirstOrDefaultAsync(j => j.Id == id);
        }

    }
}
