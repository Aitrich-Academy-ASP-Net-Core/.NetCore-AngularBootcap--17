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

        public async Task<List<CompanyUser>> GetCompanyUsers()
        {
            return await _context.CompanyUsers
                .Include(c => c.Company)
                .ToListAsync();
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

        // ✅ Category
        public async Task<JobCategory> GetCategoryByNameAsync(string name)
            => await _context.JobCategories.FirstOrDefaultAsync(c => c.Name == name);

        public async Task<JobCategory> AddCategoryAsync(JobCategory category)
        {
            _context.JobCategories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        // ✅ Location
        public async Task<Location> GetLocationByNameAsync(string name)
        {
            return await _context.Locations
                .FirstOrDefaultAsync(l => l.Name == name);
        }

        public async Task<Location> AddLocationAsync(Location location)
        {
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return location;
        }


        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs
                 //.Include(j => j.JobProvider)
                 //.Include(j => j.Category)
                 
                .Include(j => j.Location)
                .ToListAsync();
        }
        //public async Task<List<Job>> GetAllJobsAsync()
        //{
        //    return await _context.Jobs
        //        .Include(j => j.Company)
        //        .ToListAsync();
        //}



    }

}

        
        
        
        
        
        
        
        
        
        
        
        
        
        
       

      
       
