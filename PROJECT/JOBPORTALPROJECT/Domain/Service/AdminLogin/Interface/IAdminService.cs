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
        Task<JobCategory> AddCategory(JobCategory category);
        Task<Location> AddLocation(Location location);

        Task<IEnumerable<JobDto>> GetAllJobsAsync();




    }
}

