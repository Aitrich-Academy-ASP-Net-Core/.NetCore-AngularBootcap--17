using JobSeekerManagement.Dto;
using JobSeekerManagement.Models;
using Microsoft.AspNetCore.Builder;

namespace JobSeekerManagement.Interface
{
    public interface IApplicationRepository
    {
        Task AddAsync(Application application);

        Task<IEnumerable<Application>> GetByUserIdAsync(int userId);
    }
}
