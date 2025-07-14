using Workshop.DTO;
using Workshop.Models;

namespace Workshop.Interfaces
{
    public interface IJobrepository
    {
        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);
        public Task AddJobAsync(JobDto jobDto);


        public Task UpdateJobAsync(int id, Job jobDto);

        public Task DeleteJobAsync(int id);
    }
}

