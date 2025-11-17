using Domain.Helpers;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminRepository
    {
        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();

        public Task<List<CompanyUser>> GetCompanyUsers();


        public Task<List<Industry>> GetIndustries();

        public Task<List<Location>> GetLocations();

        public Task<List<JobPost>> GetJobs();

        public Task<List<JobCategory>> GetCategories();
        public void DeleteById(Guid id);
        Task<bool> DeleteByLocationIdAsync(Guid id);

        public void DeleteCompaniesById(Guid id);

        public void DeleteByCategoryId(Guid id);

         bool DeleteByIndustryId(Guid id);


        public int GetCompanyCount();

        public int GetJobProviderCount();
        public Task<List<JobPost>> GetJobs(string JobLitle);
        int GetSeekerCount();

        public int GetJobCount();

        Task<bool> AddAsync(Skill skill);
        Task<IEnumerable<Skill>> GetAllAsync();
        Task<bool> RemoveAsync(Guid skillId);


        Task<Industry> addIndustry(Industry industry);

        Task<JobCategory> addCategory(JobCategory category);

        Task<Location> addLocation(Location location);
        Task<List<JobProviderCompany>> SearchCompanies(string name);


    }

}
