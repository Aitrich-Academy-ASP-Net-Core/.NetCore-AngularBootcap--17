using DTONewProject.Models;

namespace DTONewProject.Interfaces
{
    public interface IJobService
    {
        public Task<List<Job>> GetAllJobsAsync();
        public Task<Job> AddJobByIdAsync(int id);
        //public Task AddJobAsync(JobDTO)
    }
}
