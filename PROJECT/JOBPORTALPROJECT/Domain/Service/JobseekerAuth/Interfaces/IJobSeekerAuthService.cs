using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.JobseekerAuth.Interfaces
{
    public interface IJobSeekerAuthService
    {
        Task<bool> RegisterAsync(SignUpRequest request);
        Task<string> VerifyOtpAsync(string email, string otp);
        Task<string> LoginAsync(string email, string password);
    }
}
