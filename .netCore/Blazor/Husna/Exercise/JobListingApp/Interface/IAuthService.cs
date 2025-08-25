using JobListingApp.Model;
using JobListingApp.Dto;

namespace JobListingApp.Interface
{
    public interface IAuthService
    {
        Task<JobSeekerDto> RegisterAsync(JobSeekerDto jobSeekerDto);
        Task<JobSeekerDto?> AuthenticateAsync(string email, string password);
        Task<bool> JobSeekerExistsAsync(string email);
    }
}
