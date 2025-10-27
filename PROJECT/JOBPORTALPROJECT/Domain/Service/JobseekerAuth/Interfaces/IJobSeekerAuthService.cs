using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Authuser.Dto;

using Domain.Service.JobseekerAuth.Dto;

namespace Domain.Service.JobseekerAuth.Interfaces
{
    public interface IJobSeekerAuthService
    {
        //Task<Guid> RegisterAsync(JobSeekerRegisterDto dto);
        Task<Guid> RegisterAsync(JobSeekerRegisterDto dto, string? password = null);
        Task VerifyEmailByIdAsync(Guid id, string email);
        Task SetPasswordAsync(Guid userId, string password);
        Task<JobSeekerLoginDto?> LoginAsync(string email, string password);

            //Task VerifyEmailByIdAsync(Guid id, string email);
            //Task SetPasswordAsync(Guid userId, string password);
            //Task SetPasswordAsync(Guid userId, string password);
        }
}
