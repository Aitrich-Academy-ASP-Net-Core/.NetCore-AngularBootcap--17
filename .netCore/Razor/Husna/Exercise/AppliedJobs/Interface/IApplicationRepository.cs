using AppliedJobs.Dto;
namespace AppliedJobs.Interface
{
    public interface IApplicationRepository
    {
        Task ApplyToJobAsync(int jobId, int userId);
        Task<List<ApplicationDto>> GetAppliedJobsAsync(int userId);
    }
}
