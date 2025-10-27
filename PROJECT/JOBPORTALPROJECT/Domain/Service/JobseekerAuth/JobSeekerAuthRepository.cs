using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.JobseekerAuth.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.JobseekerAuth
{
    public class JobSeekerAuthRepository : IJobSeekerAuthRepository
    {
        private readonly AppDbContext _context;

        public JobSeekerAuthRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddJobSeekerAsync(AuthUser user)
        {
            await _context.AuthUsers.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<AuthUser?> GetUserByIdAsync(Guid userId)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task UpdateUserAsync(AuthUser user)
        {
            _context.AuthUsers.Update(user);
            await _context.SaveChangesAsync();
        }


        public async Task AddAsync(JobSeeker jobSeeker)
        {
            _context.JobSeekers.Add(jobSeeker);
            await _context.SaveChangesAsync();
        }

        public async Task<JobSeeker?> GetByIdAsync(Guid id)
        {
            return await _context.JobSeekers.FindAsync(id);
        }

    }
}

