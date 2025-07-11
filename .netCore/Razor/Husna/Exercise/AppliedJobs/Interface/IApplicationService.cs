using AppliedJobs.Dto;

namespace AppliedJobs.Interface
{
    public interface IApplicationService
    {
        Task ApplyToJobAsync(int jobId, int userId);
        Task<List<ApplicationDto>> GetAppliedJobsAsync(int userId);
    }
}
