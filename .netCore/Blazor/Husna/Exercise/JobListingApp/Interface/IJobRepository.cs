using JobListingApp.Model;

namespace JobListingApp.Interface
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobsAsync();
        Task<Job> GetJobByIdAsync(int id);
    }
}
