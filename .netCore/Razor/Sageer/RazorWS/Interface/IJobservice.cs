using RazorWS.DTO;
using RazorWS.Models;
using Microsoft.EntityFrameworkCore;

namespace RazorWS.Interface
{
    public interface IJobservice
    {
        public Task<List<JobApplication>> GetAllJobAsync();
        public Task<JobApplication> GetJobByIdAsync(int id);
        public Task AddJobAsync(JobDto jobDto);
        public Task UpdateJobAsync(int id, JobApplication jobDto);
        public Task DeleteJobAsync(int id);
    }
}
