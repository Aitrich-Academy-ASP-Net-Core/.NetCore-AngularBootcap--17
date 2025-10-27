using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.AdminLogin.Interface;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.AdminLogin
{
    public class AdminRepository : IAdminRepository
    {
        private readonly List<Domain.Models.JobSeeker> _jobSeeker;
        AppDbContext _context;
        IMapper _mapper;

        public AdminRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Domain.Models.JobSeeker>> GetJobSeekers()
        {
            return await _context.JobSeekers.ToListAsync();
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _context.Companies.ToListAsync();

        }

        public async Task<List<JobProviderCompany>> SearchCompaniesAsync(string searchTerm)
        {
            return await _context.Companies
                .Where(c => c.LegalName.Contains(searchTerm) || c.Website.Contains(searchTerm))
                .ToListAsync();
        }



        public async Task<List<CompanyUser>> GetCompanyUsers()
        {
            return await _context.CompanyUsers
                .Include(c => c.Company)
                .ToListAsync();
        }

        public async Task<bool> RemoveCompanyAsync(Guid companyId)
        {
            var company = await _context.Companies
                .Include(c => c.CompanyUsers) // optional: handle cascade
                .FirstOrDefaultAsync(c => c.Id == companyId);

            if (company == null)
                return false;

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveCompanyUserAsync(Guid userId)
        {
            var user = await _context.CompanyUsers.FindAsync(userId);
            if (user == null)
                return false;

            _context.CompanyUsers.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }


        // ✅ Skill





        public async Task<Skill> AddSkillAsync(Skill skill)
        {
            await _context.Skills.AddAsync(skill);
            await _context.SaveChangesAsync();
            return skill;
        }

        public async Task<Skill> GetSkillByNameAsync(string name)
        {
            return await _context.Skills.FirstOrDefaultAsync(s => s.Name == name);
        }


        public async Task<bool> RemoveSkillAsync(Guid skillId)
        {
            var skill = await _context.Skills.FindAsync(skillId);
            if (skill == null) return false;

            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();
            return true;
        }

        

        public async Task<List<Skill>> GetAllSkillsAsync()
        {
            return await _context.Skills.ToListAsync();
        }

        // ✅ Industry
        public async Task<Industry> GetIndustryByNameAsync(string name)
            => await _context.Industries.FirstOrDefaultAsync(i => i.Name == name);

        public async Task<Industry> AddIndustryAsync(Industry industry)
        {
            _context.Industries.Add(industry);
            await _context.SaveChangesAsync();
            return industry;
        }


        public async Task<bool> RemoveIndustryAsync(Guid industryId)
        {
            var industry = await _context.Industries.FindAsync(industryId);
            if (industry == null) return false;

            _context.Industries.Remove(industry);
            await _context.SaveChangesAsync();
            return true;
        }

        // ✅ Category
        public async Task<JobCategory> GetCategoryByNameAsync(string name)
            => await _context.JobCategories.FirstOrDefaultAsync(c => c.Name == name);

        public async Task<JobCategory> AddCategoryAsync(JobCategory category)
        {
            _context.JobCategories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }
        // ✅ Get all job categories
        public async Task<List<JobCategory>> GetCategoriesAsync()
        {
            return await _context.JobCategories.ToListAsync();
        }
        public async Task<List<Industry>> GetIndustriesAsync()
        {
            return await _context.Industries.ToListAsync();
        }


        public async Task<bool> RemoveCategoryAsync(Guid categoryId)
        {
            var category = await _context.JobCategories.FindAsync(categoryId);
            if (category == null) return false;

            _context.JobCategories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }


        // ✅ Location
        public async Task<Location> GetLocationByNameAsync(string name)
        {
            return await _context.Locations
                .FirstOrDefaultAsync(l => l.Name == name);
        }
        // ✅ Get all locations
        public async Task<List<Location>> GetLocationsAsync()
        {
            return await _context.Locations.ToListAsync();
        }

       
        public async Task<Location> AddLocationAsync(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return location;
        }

        public async Task<bool> RemoveLocationAsync(Guid locationId)
        {
            var location = await _context.Locations.FindAsync(locationId);
            if (location == null) return false;

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return true;
        }



        //ALL JOBS


        public async Task<List<JobPost>> GetAllJobsAsync()
        {
            return await _context.JobPosts
                .Include(j => j.PostedBy)
                .Include(j => j.Location)
                .Include(j => j.Industry)
                .Include(j => j.JobCategory)
                .ToListAsync();
        }
        //COUNT

        // Count total Job Providers
        public async Task<int> GetJobProviderCountAsync()
        {
            return await _context.CompanyUsers.CountAsync();
        }

        // Count total Job Seekers
        public async Task<int> GetJobSeekerCountAsync()
        {
            return await _context.JobSeekers.CountAsync();
        }

        //  Count total Jobs
        public async Task<int> GetJobCountAsync()
        {
            return await _context.JobPosts.CountAsync();
        }

    }

}

        
        
        
        
        
        
        
        
        
        
        
        
        
        
       

      
       
