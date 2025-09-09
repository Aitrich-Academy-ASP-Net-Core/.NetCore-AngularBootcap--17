using AutoMapper;
using JobSeekerManagement.Models;
using JobSeekerManagement.Dto;
using JobSeekerManagement.Interface;

namespace JobSeekerManagement.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _repo;
        private readonly IMapper _mapper;

        public JobService(IJobRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobDto>> GetAllAsync()
        {
            var jobs = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<JobDto>>(jobs);
        }

        public async Task<JobDto?> GetByIdAsync(int id)
        {
            var job = await _repo.GetByIdAsync(id);
            return _mapper.Map<JobDto?>(job);
        }
    
    }
}

