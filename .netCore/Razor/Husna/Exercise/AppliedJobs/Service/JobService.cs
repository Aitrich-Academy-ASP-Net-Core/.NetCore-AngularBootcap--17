using AppliedJobs.Dto;
using AppliedJobs.Interface;
using AppliedJobs.Model;
using AppliedJobs.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AppliedJobs.Service
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _jobRepository.GetAllJobsAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await _jobRepository.GetJobByIdAsync(id);
        }

        public async Task AddJobAsync(JobDto jobDto)
        {
            await _jobRepository.AddJobAsync(jobDto);
        }
    }
}
