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
        Task<List<Industry>> GetIndustriesAsync();
        Task<Industry> AddIndustryAsync(Industry industry);
        Task<bool> RemoveIndustryAsync(Guid industryId);
        // Category
        Task<List<JobCategory>> GetCategoriesAsync();
        Task<JobCategory> GetCategoryByNameAsync(string name);
        Task<JobCategory> AddCategoryAsync(JobCategory category);
        Task<bool> RemoveCategoryAsync(Guid categoryId);
        // Location
        Task<Location> GetLocationByNameAsync(string name);
        Task<List<Location>> GetLocationsAsync();
        Task<Location> AddLocationAsync(Location location);
        Task<bool> RemoveLocationAsync(Guid locationId);

        Task<List<JobPost>> GetAllJobsAsync();


        Task<int> GetJobProviderCountAsync();
        Task<int> GetJobSeekerCountAsync();
        Task<int> GetJobCountAsync();

        Task<List<JobProviderCompany>> SearchCompaniesAsync(string searchTerm);

        Task<bool> RemoveCompanyAsync(Guid companyId);
        Task<bool> RemoveCompanyUserAsync(Guid userId);












    }
}
