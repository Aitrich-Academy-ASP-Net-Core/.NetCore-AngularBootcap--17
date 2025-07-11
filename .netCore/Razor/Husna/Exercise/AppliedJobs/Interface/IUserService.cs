using AppliedJobs.Model;

namespace AppliedJobs.Interface
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(User user);
        Task<User> LoginAsync(string username, string password);
        Task<User> GetUserByIdAsync(int id);
    }
}
