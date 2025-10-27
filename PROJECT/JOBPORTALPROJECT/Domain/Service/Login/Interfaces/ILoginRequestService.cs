using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Login.Dtos;

namespace Domain.Service.Login.Interfaces
{
    public interface ILoginRequestService
    {

        Task<JobSeekerLoginDto?> JobSeekerLoginAsync(string email, string password);
        Task<AdminLoginDto?> AdminLoginAsync(string email, string password);
    }
}
