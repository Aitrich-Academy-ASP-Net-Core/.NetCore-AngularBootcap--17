using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.AdminLogin;
using Domain.Service.AdminLogin.DTOs;

namespace Domain.Service.AdminLogin.Interface
{
    public interface IAdminService
    {



        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();

        public Task<List<JobProviderCompany>> GetCompanies();

        public Task<List<CompanyUser>> GetCompanyUsers();


        Task<List<Skill>> GetAllSkillsAsync();

        Task<SkillDto?> AddSkillAsync(SkillDto skillDto);
        Task<bool> RemoveSkillAsync(Guid skillId);

        Task<Industry> AddIndustry(Industry industry);
        Task<List<Industry>> GetIndustriesAsync();


        Task<bool> RemoveIndustryAsync(Guid industryId);
        Task<JobCategory> AddCategory(JobCategory category);
        Task<List<JobCategory>> GetCategoriesAsync();
        Task<bool> RemoveCategoryAsync(Guid categoryId);
        Task<Location> AddLocation(Location location);
        Task<List<Location>> GetLocationsAsync();
        Task<bool> RemoveLocationAsync(Guid locationId);
        Task<IEnumerable<JobpostDto>> GetAllJobsAsync();

        Task<int> GetJobProviderCountAsync();
        Task<int> GetJobSeekerCountAsync();
        Task<int> GetJobCountAsync();
        Task<List<JobProviderCompany>> SearchCompaniesAsync(string searchTerm);

        Task<bool> RemoveCompanyAsync(Guid companyId);

        Task<bool> RemoveCompanyUserAsync(Guid userId);

    }
}

