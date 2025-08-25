using JobListingApp.Model;

namespace JobListingApp.Interface
{
    public interface IJobSeekerRepository
    {
        Task<JobSeeker> RegisterAsync(JobSeeker jobSeeker);
        Task<JobSeeker> LoginAsync(string email, string password);
        Task<bool> JobSeekerExistsAsync(string email);
        
        
            Task<JobSeeker?> GetByEmailAsync(string email);
            // other methods...
        

    }
}
