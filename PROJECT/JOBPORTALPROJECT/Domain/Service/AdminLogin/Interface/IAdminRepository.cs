using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.AdminLogin.Interface
{
    public interface IAdminRepository
    {





        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();

        public Task<List<CompanyUser>> GetCompanyUsers();


        Task<Skill> AddSkillAsync(Skill skill);
        Task<bool> RemoveSkillAsync(Guid skillId);
        Task<Skill> GetSkillByNameAsync(string name);
        Task<List<Skill>> GetAllSkillsAsync();

        // Industry
        Task<Industry> GetIndustryByNameAsync(string name);
        Task<Industry> AddIndustryAsync(Industry industry);

        // Category
        Task<JobCategory> GetCategoryByNameAsync(string name);
        Task<JobCategory> AddCategoryAsync(JobCategory category);

        // Location
        Task<Location> GetLocationByNameAsync(string name);
        Task<Location> AddLocationAsync(Location location);
        Task<IEnumerable<Job>> GetAllJobsAsync();




















    }
}
