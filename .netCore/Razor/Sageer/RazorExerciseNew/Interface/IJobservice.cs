using Microsoft.AspNetCore.Builder;

namespace RazorExerciseNew.Interface
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
