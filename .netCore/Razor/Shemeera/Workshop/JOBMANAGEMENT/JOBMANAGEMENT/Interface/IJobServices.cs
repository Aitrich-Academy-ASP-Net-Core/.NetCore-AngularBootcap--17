using JOBMANAGEMENT.Dto;
using JOBMANAGEMENT.Model;

namespace JOBMANAGEMENT.Interface
{
    public interface IJobServices
    {

        public Task<List<Jobs>> GetAllJobsAsync();

        public Task<Jobs> GetJobByIdAsync(int id);


        public Task AddJobAsync(JobsDto jobDto);


        public Task UpdateJobAsync(int id, Jobs jobDto);

        public Task DeleteJobAsync(int id);





    }
}
