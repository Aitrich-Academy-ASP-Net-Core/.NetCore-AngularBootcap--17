using AppliedJobs.Model;

namespace AppliedJobs.Interface
{
    public interface IUserRepository
    {
        Task<bool> RegisterUserAsync(User user);
        Task<User> LoginAsync(string username, string password);
        Task<User> GetUserByIdAsync(int id);
    }
}
