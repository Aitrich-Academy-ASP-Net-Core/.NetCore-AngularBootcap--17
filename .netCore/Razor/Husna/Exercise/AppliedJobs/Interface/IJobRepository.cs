using AppliedJobs.Dto;
using AppliedJobs.Model;

namespace AppliedJobs.Interface
{
    public interface IJobRepository
    {
        public Task<List<Job>> GetAllJobsAsync();
        public Task<Job> GetJobByIdAsync(int id);
        public Task AddJobAsync(JobDto jobDto);

    }
}
