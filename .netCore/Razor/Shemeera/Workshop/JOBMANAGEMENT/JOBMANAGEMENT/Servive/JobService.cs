using AutoMapper;
using JOBMANAGEMENT.Dto;
using JOBMANAGEMENT.Interface;
using JOBMANAGEMENT.Model;
using JOBMANAGEMENT.Repository;
using Microsoft.EntityFrameworkCore;

namespace JOBMANAGEMENT.Servive
{
    public class JobService:IJobServices
    {

        private readonly JobRepository jobRepository;

        public JobService(JobRepository _jobRepository)
        {
            jobRepository = _jobRepository;
        }

        public async Task<List<Jobs>> GetAllJobsAsync()
        {
            return await jobRepository.GetAllJobsAsync();
        }

        public async Task<Jobs> GetJobByIdAsync(int id)
        {
            return await jobRepository.GetJobByIdAsync(id);
        }

        public async Task AddJobAsync(JobsDto jobDto)
        {
            await jobRepository.AddJobAsync(jobDto);
        }

        public async Task UpdateJobAsync(int id, Jobs jobDto)
        {
            await jobRepository.UpdateJobAsync(id, jobDto);
        }

        public async Task DeleteJobAsync(int id)
        {
            await jobRepository.DeleteJobAsync(id);
        }
    }
}
