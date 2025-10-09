using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.AdminLogin.DTOs;
using Domain.Service.AdminLogin.Interface;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Generators;





namespace Domain.Service.AdminLogin
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;

        public AdminService(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task<List<JobSeeker>> GetJobSeekers()
        {
            return await _adminRepository.GetJobSeekers();
        }
        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _adminRepository.GetCompanies();
        }

        public async Task<List<CompanyUser>> GetCompanyUsers()
        {
            return await _adminRepository.GetCompanyUsers();
        }

        public async Task<List<Skill>> GetAllSkillsAsync()
        {
            return await _adminRepository.GetAllSkillsAsync();
        }


        // =================== Add Skill ===================
        public async Task<SkillDto?> AddSkillAsync(SkillDto skillDto)
        {
            // Map DTO to entity
            var skill = _mapper.Map<Skill>(skillDto);
            skill.Id = Guid.NewGuid(); // Ensure the ID is created before saving

            // Optional: check for duplicates
            var existing = await _adminRepository.GetSkillByNameAsync(skill.Name);
            if (existing != null)
                return null; // means already exists

            // Save to DB
            await _adminRepository.AddSkillAsync(skill);

            // Map back to DTO and return it
            return _mapper.Map<SkillDto>(skill);
        }

        // =================== Remove Skill ===================
        public async Task<bool> RemoveSkillAsync(Guid skillId)
        {
            return await _adminRepository.RemoveSkillAsync(skillId);
        }

        // ✅ Add Industry
        public async Task<Industry> AddIndustry(Industry industry)
        {
            var existing = await _adminRepository.GetIndustryByNameAsync(industry.Name);
            if (existing != null)
                return existing; // return existing instead of duplicate

            return await _adminRepository.AddIndustryAsync(industry);
        }

        // ✅ Add Category
        public async Task<JobCategory> AddCategory(JobCategory category)
        {
            var existing = await _adminRepository.GetCategoryByNameAsync(category.Name);
            if (existing != null)
                return existing;

            return await _adminRepository.AddCategoryAsync(category);
        }

        // ✅ Add Location
        public async Task<Location> AddLocation(Location location)
        {
            // Check if a location with the same name already exists
            var existing = await _adminRepository.GetLocationByNameAsync(location.Name);
            if (existing != null)
                return existing;

            // Add new location
            return await _adminRepository.AddLocationAsync(location);
        }

        public async Task<IEnumerable<JobDto>> GetAllJobsAsync()
        {
            var jobs = await _adminRepository.GetAllJobsAsync();
            return _mapper.Map<IEnumerable<JobDto>>(jobs);
        }


    }
}

