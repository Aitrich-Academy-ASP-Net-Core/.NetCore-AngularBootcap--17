using JOBPORTALNEW.JobDto;
using JOBPORTALNEW.Model;

namespace JOBPORTALNEW.Interface
{
    public interface IRepository
    {

        Task<User> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);
        Task<User> LoginAsync(string username, string password);

       
        Task<List<Job>> GetAllJobsAsync();

        Task ApplyToJobAsync(int jobId, int userId);
        Task<List<AppliedDto>> GetAppliedJobsByUserIdAsync(int userId);

    }
}
