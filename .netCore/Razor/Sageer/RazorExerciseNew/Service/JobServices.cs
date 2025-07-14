using Microsoft.AspNetCore.Builder;
using RazorExerciseNew.Models;
using RazorExerciseNew.DTO;
using RazorExerciseNew.Repository;
using RazorExerciseNew.Extension;
using RazorExerciseNew.Helper;
using RazorExerciseNew.Interface;
namespace RazorExerciseNew.Service
{
    public class JobServices
    {
        private readonly Jobrepo _context;
        public JobServices(Jobrepo context)
        {
            _context = context;
        }
        public async Task<List<Application>> GetAllJobAsync()
        {
            return await _context.GetAllJobAsync();
        }
        public async Task AddJobAsync(JobDto jobDto)
        {
            await _context.AddJobAsync(jobDto);
        }
        public async Task<Application> GetJobByIdAsync(int id)
        {
            return await _context.GetJobByIdAsync(id);
        }
        public async Task UpdateJobAsync(int id, Application jobDto)
        {
            await _context.UpdateJobAsync(id, jobDto);
        }
        public async Task DeleteJobAsync(int id)
        {
            await _context.DeleteJobAsync(id);
        }
    }
}
