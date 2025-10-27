using JobSeekerManagement.Dto;
using JobSeekerManagement.Models;

namespace JobSeekerManagement.Interface
{
    public interface IJobService
    {
        // List all jobs (for JobSeeker to browse)
        Task<IEnumerable<JobDto>> GetAllAsync();

        // Get details of a specific job
        Task<JobDto?> GetByIdAsync(int id);
    }
}
