using JobSeekerManagement.Models;

namespace JobSeekerManagement.Interface
{
    public interface IPublicRepository
    {
        Task RegisterAsync(User user); // Save new user
        Task<User?> LoginAsync(string email, string password); // Validate user
    }
}
