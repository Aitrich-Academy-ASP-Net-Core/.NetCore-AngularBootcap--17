using AutoMapper;
using JobSeekerManagement.Models;
using JobSeekerManagement.Dto;
using JobSeekerManagement.Interface;
using Microsoft.AspNetCore.Builder;

namespace JobSeekerManagement.Service
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _repo;
        private readonly IMapper _mapper;

        public ApplicationService(IApplicationRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task AddAsync(ApplicationDto applicationDto)
        {
            var application = _mapper.Map<Application>(applicationDto);
            await _repo.AddAsync(application);
        }

        public async Task<IEnumerable<ApplicationDto>> GetByUserIdAsync(int userId)
        {
            var apps = await _repo.GetByUserIdAsync(userId);
            return _mapper.Map<IEnumerable<ApplicationDto>>(apps);
        }
        public async Task ApplyAsync(int jobId, string userId)
        {
            var application = new Application
            {
                JobId = jobId,
                UserId = int.Parse(userId), // ✅ convert to int
                AppliedOn = DateTime.UtcNow
            };

            await _repo.AddAsync(application);
        }


    }



}
