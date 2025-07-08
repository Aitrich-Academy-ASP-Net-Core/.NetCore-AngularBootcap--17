using Workshop.DTO;
using Workshop.Interfaces;
using Workshop.Models;
using Workshop.Repository;
namespace Workshop.Services
{
    public class JobServices : IJobservice
    {
        private readonly JobRepo jobservices;
        public JobServices(JobRepo _jobservices)
        {
            jobservices = _jobservices;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await jobservices.GetAllJobsAsync();
        }
        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await jobservices.GetJobByIdAsync(id);
        }
        public async Task AddJobAsync(JobDto jobDto)
        {
             await jobservices.AddJobAsync(jobDto);
        }
        public async Task UpdateJobAsync(int id, Job jobDto)
        {
            await jobservices.UpdateJobAsync(id, jobDto);
        }
        public async Task DeleteJobAsync(int id)
        {
             await jobservices.DeleteJobAsync(id);
        }

        }
}
