using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Domain.Service.JobseekerAuth.Interfaces
{
    public class JobSeekerAuthService : IJobSeekerAuthService
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;
        private readonly IEmailService _emailService;
        private readonly IAuthUserRepository _authUserRepository;

        public JobSeekerAuthService(
            AppDbContext context,
            IConfiguration config,
            IEmailService emailService,
            IAuthUserRepository authUserRepository)
        {
            _context = context;
            _config = config;
            _emailService = emailService;
            _authUserRepository = authUserRepository;
        }

        // ✅ REGISTER (SignUp)
        public async Task<bool> RegisterAsync(SignUpRequest request)
        {
            // Check duplicate email
            if (await _context.AuthUsers.AnyAsync(u => u.Email == request.Email))
                return false;

            // Save AuthUser
            var authUser = new AuthUser
            {
                Id = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Role = Role.JOB_SEEKER,
                Password = PasswordHelper.HashPassword(request.Phone), // default temp password
                CreatedAt = DateTime.UtcNow
            };
            await _context.AuthUsers.AddAsync(authUser);

            // Save SignUpRequest with OTP
            request.OTP = new Random().Next(100000, 999999).ToString();
            request.Status = Status.PENDING;
            await _context.SignUpRequests.AddAsync(request);

            await _context.SaveChangesAsync();

            // Send OTP mail
            await _emailService.SendEmailAsync(new MailRequest
            {
                ToEmail = request.Email,
                Subject = "Verify your HireMeNow account",
                Body = $"Your OTP is: <b>{request.OTP}</b>"
            });

            return true;
        }

        // ✅ VERIFY OTP
        public async Task<string> VerifyOtpAsync(string email, string otp)
        {
            var user = await _context.SignUpRequests.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null || user.OTP != otp)
                return "Invalid OTP";

            user.Status = Status.VERIFIED;
            await _context.SaveChangesAsync();
            return "Email Verified Successfully!";
        }

        // ✅ LOGIN
        public async Task<string> LoginAsync(string email, string password)
        {
            var user = await _context.AuthUsers
                .FirstOrDefaultAsync(x => x.Email == email && x.Role == Role.JOB_SEEKER);

            if (user == null)
                return null;

            if (!PasswordHelper.VerifyPassword(password, user.Password))
                return null;

            return _authUserRepository.CreateToken(user);
        }
    }
}

