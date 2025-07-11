using AppliedJobs.Dto;
using AppliedJobs.Interface;
using AppliedJobs.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AppliedJobs.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ApplicationRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Apply user to a job
        public async Task ApplyToJobAsync(int jobId, int userId)
        {
            var alreadyApplied = await _context.Applications
                .AnyAsync(a => a.JobId == jobId && a.UserId == userId);

            if (!alreadyApplied)
            {
                var application = new Application
                {
                    JobId = jobId,
                    UserId = userId,
                    AppliedOn = DateTime.Now
                };

                _context.Applications.Add(application);
                await _context.SaveChangesAsync();
            }
        }

        // Get all jobs applied by a specific user
        public async Task<List<ApplicationDto>> GetAppliedJobsAsync(int userId)
        {
            var applications = await _context.Applications
       .Include(a => a.Job)
       .Where(a => a.UserId == userId)
       .ToListAsync();

            foreach (var app in applications)
            {
                Console.WriteLine($"Job: {app.Job?.Title}, AppliedOn: {app.AppliedOn}");
            }

            return applications.Select(a => new ApplicationDto
            {
                JobTitle = a.Job?.Title ?? "NULL",
                Location = a.Job?.Location ?? "NULL",
                AppliedOn = a.AppliedOn
            }).ToList();

        }
    }
}
