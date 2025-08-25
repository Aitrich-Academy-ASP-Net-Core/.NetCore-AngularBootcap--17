using JobListingApp.Model;
using JobListingApp.Dto;

namespace JobListingApp.Interface
{
    public interface IJobService
    {
        Task<List<JobDto>> GetAllJobsAsync();
        Task<JobDto> GetJobByIdAsync(int id);
    }
}
