using JobProvider.Interface;
using JobProvider.Model;
using Microsoft.EntityFrameworkCore;

namespace JobProvider.Repository
{
    
        public class JobProviderRepository : IJobProviderRepository
        {
            private readonly JobProviderAppDbContext _context;

            public JobProviderRepository(JobProviderAppDbContext context)
            {
                _context = context;
            }

            public async Task<JobProviderr> GetByEmailAsync(string email)
            {
                return await _context.JobProviders.FirstOrDefaultAsync(jp => jp.Email == email);
            }

            public async Task AddAsync(JobProviderr jobProvider)
            {
                _context.JobProviders.Add(jobProvider);
                await _context.SaveChangesAsync();
            }
        }
}
