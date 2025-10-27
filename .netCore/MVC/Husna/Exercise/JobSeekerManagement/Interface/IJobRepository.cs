using JobSeekerManagement.Dto;
using JobSeekerManagement.Models;

namespace JobSeekerManagement.Interface
{
    public interface IJobRepository
    {
        // List all jobs (for JobSeeker to browse)
        Task<IEnumerable<Job>> GetAllAsync();

        // Get details of a specific job
        Task<Job?> GetByIdAsync(int id);
    }
}
