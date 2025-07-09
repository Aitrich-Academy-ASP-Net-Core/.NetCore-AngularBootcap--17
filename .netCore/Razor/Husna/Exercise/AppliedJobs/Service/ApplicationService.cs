using AppliedJobs.Dto;
using AppliedJobs.Interface;
using AppliedJobs.Repository;
using Microsoft.EntityFrameworkCore;

namespace AppliedJobs.Service
{
    public class ApplicationService:IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationService(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task ApplyToJobAsync(int jobId, int userId)
        {
            await _applicationRepository.ApplyToJobAsync(jobId, userId);
        }

        public async Task<List<ApplicationDto>> GetAppliedJobsAsync(int userId)
        {
            return await _applicationRepository.GetAppliedJobsAsync(userId);
        }
    }
}
