using Microsoft.AspNetCore.Builder;
using RazorExerciseNew.Models;
using RazorExerciseNew.DTO;
namespace RazorExerciseNew.Interface
{
    public interface IJobrepository
    {
        public Task<List<Application>> GetAllJobAsync();
        public Task<Application> GetJobByIdAsync(int id);
        public Task AddJobAsync(JobDto jobDto);
        public Task UpdateJobAsync(int id, Application jobDto);
        public Task DeleteJobAsync(int id);
    }
}
