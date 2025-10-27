using JobSeekerManagement.Interface;
using JobSeekerManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace JobSeekerManagement.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job?> GetByIdAsync(int id)
        {
            return await _context.Jobs.FirstOrDefaultAsync(j => j.Id == id);
        }
    }
    
    
}
