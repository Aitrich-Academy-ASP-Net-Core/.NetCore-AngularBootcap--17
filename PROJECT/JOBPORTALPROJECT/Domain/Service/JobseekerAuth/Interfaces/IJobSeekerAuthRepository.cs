using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.JobseekerAuth.Interfaces
{
    public interface IJobSeekerAuthRepository
    {

        Task AddJobSeekerAsync(AuthUser user);
        Task<AuthUser?> GetUserByIdAsync(Guid userId);
        //Task<AuthUser> GetUserByEmailAsync(string email);
        Task UpdateUserAsync(AuthUser user);

        Task AddAsync(JobSeeker jobSeeker);
        Task<JobSeeker?> GetByIdAsync(Guid id);
        //Task AddJobSeekerProfileAsync(JobSeeker jobSeeker);
        //Task SetPasswordAsync(Guid userId, string password);


    }
}
