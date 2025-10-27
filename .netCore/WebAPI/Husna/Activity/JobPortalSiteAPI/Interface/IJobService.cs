using JobPortal.Dto;

namespace JobPortal.Interface
{
    public interface IJobService
    {

        Task<IEnumerable<JobDto>> GetJobsAsync();
        Task<JobDto> GetJobByIdAsync(int id);
        Task<JobDto> AddJobAsync(JobDto jobDto);
        Task<JobDto> UpdateJobAsync(int id, JobDto jobDto);
        Task<bool> DeleteJobAsync(int id);



    }
}
