using JobPortalMVC.Models;

namespace JobPortalMVC.Interface
{
    public interface IJobService
    {
        public List<Job> GetJobs();

        public List<Job> GetJobPosted(Guid cmpid);
    }
}
