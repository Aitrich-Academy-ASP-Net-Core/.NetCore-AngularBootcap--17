using AppliedJobs.Dto;
using AppliedJobs.Model;
namespace AppliedJobs.Interface
{
    public interface IJobService
    {
        Task<List<Job>> GetAllJobsAsync();   // For job listing
        Task<Job> GetJobByIdAsync(int id);   // View job details
        Task AddJobAsync(JobDto jobDto);
    }
}
