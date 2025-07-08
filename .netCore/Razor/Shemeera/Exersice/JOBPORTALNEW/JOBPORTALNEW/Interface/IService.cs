using JOBPORTALNEW.JobDto;

namespace JOBPORTALNEW.Interface
{
    public interface IService
    {
        Task<UserDto> GetByUsernameAsync(string username);
        Task AddUserAsync(UserDto userDto);
        Task<UserDto> LoginAsync(string username, string password);

        
        Task<List<JobsDto>> GetAllJobsAsync();


        Task ApplyToJobAsync(int jobId, int userId);
        Task<List<AppliedDto>> GetAppliedJobsByUserIdAsync(int userId);




    }
}
