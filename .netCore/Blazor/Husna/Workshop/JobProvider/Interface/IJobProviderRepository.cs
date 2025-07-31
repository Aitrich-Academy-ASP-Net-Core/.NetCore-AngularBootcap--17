using JobProvider.Model;

namespace JobProvider.Interface
{
    public interface IJobProviderRepository
    {
        Task<JobProviderr> GetByEmailAsync(string email);
        Task AddAsync(JobProviderr jobProvider);
    }
}
