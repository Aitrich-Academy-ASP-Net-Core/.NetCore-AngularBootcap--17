using JOBPORTALNEW.Interface;
using JOBPORTALNEW.JobDto;
using JOBPORTALNEW.Model;
using Microsoft.EntityFrameworkCore;

namespace JOBPORTALNEW.Repository
{
    public class JobRepository : IRepository
    {
        private readonly JobDbContext _context;

        public JobRepository(JobDbContext context)
        {
            _context = context;
        }

        // User 
        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            return await _context.Users
                .SingleOrDefaultAsync(u => u.Username == username && u.Password == password);
        }

        // Job 
        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        // Applied 
        public async Task ApplyToJobAsync(int jobId, int userId)
        {
            var application = new Applied
            {
                JobId = jobId,
                UserId = userId,
                AppliedDate = DateTime.UtcNow
            };

            _context.AppliedJobs.Add(application);
            await _context.SaveChangesAsync();
        }

        // Return applied jobs 
        public async Task<List<AppliedDto>> GetAppliedJobsByUserIdAsync(int userId)
        {
            var appliedJobs = await _context.AppliedJobs
                .Include(a => a.Job)
                .Where(a => a.UserId == userId)
                .ToListAsync();

            
            return appliedJobs.Select(a => new AppliedDto
            {
                Id = a.Id,
                JobId = a.JobId,
                UserId = a.UserId,
                AppliedDate = a.AppliedDate,
                JobTitle = a.Job.Title,
                Description = a.Job.Description,
                Location = a.Job.Location
            }).ToList();
        }


    }
    
}
