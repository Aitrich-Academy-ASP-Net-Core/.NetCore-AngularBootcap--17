using DTONewProject.DTO;
using DTONewProject.Models;

namespace DTONewProject.Interfaces
{
    public interface Jobrepository
    {
        public Task<List<Job>> GetAllJobsAsync();
        public Task<Job> AddJobByIdAsync(int id);
    }
}
