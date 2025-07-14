using AutoMapper;
using RazorWS.Interface;
using RazorWS.Models;
using RazorWS.Repository;
using RazorWS.DTO;
using RazorWS.Models;
using RazorWS.Interface;
namespace RazorWS.Services
{
    public class JobServices : IJobservice
    {
        private readonly JobRepo _context;
        public JobServices(JobRepo context)
        {
            _context = context;
        }
        public async Task <List<JobApplication>> GetAllJobAsync()
        {
            return await _context.GetAllJobAsync();
        }
        public async Task AddJobAsync(JobDto jobDto)
        {
            await _context.AddJobAsync(jobDto);
        }
        public async Task<JobApplication> GetJobByIdAsync(int id)
        {
            return await _context.GetJobByIdAsync(id);
        }
        public async Task UpdateJobAsync(int id, JobApplication jobDto)
        {
            await _context.UpdateJobAsync(id, jobDto);
        }
        public async Task DeleteJobAsync(int id)
        {
            await _context.DeleteJobAsync(id);
        }

        
    }
}
