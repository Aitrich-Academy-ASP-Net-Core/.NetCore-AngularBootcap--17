    using JobSeekerManagement.Interface;
    using JobSeekerManagement.Models;
    using Microsoft.EntityFrameworkCore;

    namespace JobSeekerManagement.Repository
    {
        public class ApplicationRepository : IApplicationRepository
        {
            private readonly AppDbContext _context;

            public ApplicationRepository(AppDbContext context)
            {
                _context = context;
            }

            public async Task AddAsync(Application application)
            {
                await _context.Applications.AddAsync(application);
                await _context.SaveChangesAsync();
            }

            public async Task<IEnumerable<Application>> GetByUserIdAsync(int userId)
            {
                return await _context.Applications
                    .Include(a => a.Job)   // <-- bring job details
                    .Where(a => a.UserId == userId)
                    .ToListAsync();
            }


        }
    }
