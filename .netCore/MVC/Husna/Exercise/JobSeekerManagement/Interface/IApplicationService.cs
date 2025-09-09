using JobSeekerManagement.Models;
using JobSeekerManagement.Dto;
namespace JobSeekerManagement.Interface
{
    public interface IApplicationService
    {
        Task AddAsync(ApplicationDto applicationDto);
        Task ApplyAsync(int jobId, string userId);
        // Get all applications for a specific JobSeeker
        Task<IEnumerable<ApplicationDto>> GetByUserIdAsync(int userId);
    }
}
