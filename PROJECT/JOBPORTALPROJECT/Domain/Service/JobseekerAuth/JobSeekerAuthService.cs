using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;

using Domain.Service.JobseekerAuth.Dto;
using Domain.Service.JobseekerAuth.Interfaces;
using Newtonsoft.Json.Linq;

namespace Domain.Service.JobseekerAuth
{
    public class JobSeekerAuthService : IJobSeekerAuthService
    {
        private readonly IJobSeekerAuthRepository _repo;
        private readonly IAuthUserRepository _authUserRepo;
        private readonly IEmailService _emailService;

        public JobSeekerAuthService(
            IJobSeekerAuthRepository repo,
            IAuthUserRepository authUserRepo,
            IEmailService emailService)
        {
            _repo = repo;
            _authUserRepo = authUserRepo;
            _emailService = emailService;
        }

        
        // ✅ REGISTER JOBSEEKER (Safe Version)
        public async Task<Guid> RegisterAsync(JobSeekerRegisterDto dto, string? password = null)
        {
            if (string.IsNullOrWhiteSpace(dto.Email))
                throw new Exception("Email is required");

            // 1️⃣ Create AuthUser
            var user = new AuthUser
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName ?? "",
                LastName = dto.LastName ?? "",
                Email = dto.Email,
                PhoneNumber = dto.Phone ?? "",
                Role = Role.JOB_SEEKER,
                IsEmailVerified = false,
                PasswordHash = password != null ? BCrypt.Net.BCrypt.HashPassword(password) : string.Empty,
                CreatedAt = DateTime.UtcNow
            };

            await _repo.AddJobSeekerAsync(user);

            // 2️⃣ Create corresponding JobSeeker table entry
            var jobSeeker = new JobSeeker
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Role = (int)Role.JOB_SEEKER,
                CreatedAt = DateTime.UtcNow,
                IsEmailVerified = false,
                PasswordHash = user.PasswordHash,
                DateOfBirth = dto.DateOfBirth ?? new DateTime(1990, 1, 1) // fallback default
            };

            await _repo.AddAsync(jobSeeker);

            // 3️⃣ Send email verification
            var link = $"https://localhost:7249/api/jobseeker/auth/verify-email?id={user.Id}&email={user.Email}";
            await _emailService.SendEmailAsync(new MailRequest
            {
                ToEmail = user.Email,
                Subject = "Verify your email",
                Body = $"Click <a href='{link}'>here</a> to verify your email."
            });

            return user.Id;
        }


        // ✅ VERIFY EMAIL
        public async Task VerifyEmailByIdAsync(Guid id, string email)
        {
            var user = await _repo.GetUserByIdAsync(id);
            if (user == null || user.Email != email)
                throw new Exception("User not found or email mismatch.");

            user.IsEmailVerified = true;
            await _repo.UpdateUserAsync(user);
        }

        // ✅ SET PASSWORD
        public async Task SetPasswordAsync(Guid userId, string password)
        {
            var user = await _repo.GetUserByIdAsync(userId);
            if (user == null) throw new Exception("User not found");

            // Hash the password before saving
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);

            await _repo.UpdateUserAsync(user);
        }

        // ✅ LOGIN
        public async Task<JobSeekerLoginDto?> LoginAsync(string email, string password)
        {
            var user = await _authUserRepo.GetAuthUserByUserEmail(email);
            if (user == null || user.Role != Role.JOB_SEEKER || !user.IsEmailVerified)
                return null;

            bool isValid = PasswordHelper.VerifyPassword(password, user.PasswordHash);
            if (!isValid) return null;

            return new JobSeekerLoginDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                Email = user.Email,
                Token = _authUserRepo.CreateToken(user)
            };
        }
    }
}



//public async Task<Guid> RegisterAsync(JobSeekerRegisterDto dto)
//{
//    var token = Guid.NewGuid().ToString();

//    var user = new AuthUser
//    {
//        Id = Guid.NewGuid(),
//        FirstName = dto.FirstName,
//        LastName = dto.LastName,
//        Email = dto.Email,
//        PhoneNumber = dto.Phone,
//        Role = Role.JOB_SEEKER,
//        IsEmailVerified = false,
//        OTP = token,
//        PasswordHash = string.Empty
//    };


//    await _repo.AddJobSeekerAsync(user);

//    // Send verification email
//    var link = $"https://localhost:7249/api/jobseeker/auth/verify-email?id={user.Id}&email={user.Email}";
//    var body = $"<p>Hello {dto.FirstName},</p><p>Click <a href='{link}'>here</a> to verify your email</p>";
//    await _emailService.SendEmailAsync(new MailRequest { ToEmail = dto.Email, Subject = "Verify Email", Body = body });

//    return user.Id;
//}

//public async Task VerifyEmailByIdAsync(Guid id, string email)
//{
//    var user = await _repo.GetUserByIdAsync(id);
//    if (user == null || user.Email != email)
//        throw new Exception("Invalid verification link.");

//    user.IsEmailVerified = true;
//    await _repo.UpdateUserAsync(user);

//    // Add profile
//    if (user.Role == Role.JOB_SEEKER)
//    {
//        var jobSeeker = new JobSeeker
//        {
//            Id = Guid.NewGuid(),
//            Email = user.Email,
//            FirstName = user.FirstName,
//            LastName = user.LastName,
//            PasswordHash = user.PasswordHash ?? string.Empty,
//            PhoneNumber = user.PhoneNumber ?? string.Empty, // ✅ add this
//            //DateOfBirth = DateTime.MinValue // Optional: if DB requires non-null
//        };


//        await _repo.AddJobSeekerProfileAsync(jobSeeker);
//    }
//}

//public async Task SetPasswordAsync(Guid userId, string password)
//{
//    var user = await _repo.GetUserByIdAsync(userId);
//    if (user == null)
//        throw new Exception("User not found.");

//    if (!user.IsEmailVerified)
//        throw new Exception("Email not verified.");

//    if (user.Role != Role.JOB_SEEKER)
//        throw new Exception("Invalid user role.");

//    // ✅ Hash password before saving
//    user.PasswordHash = PasswordHelper.HashPassword(password);
//    user.Password = null; // Optional: clear plain password field if exists
//    await _repo.UpdateUserAsync(user);
//}



//public async Task<JobSeekerLoginDto?> LoginAsync(string email, string password)
//{
//    var user = await _authUserRepo.GetAuthUserByUserEmail(email);

//    if (user == null || user.Role != Role.JOB_SEEKER)
//        return null;

//    if (!user.IsEmailVerified)
//        return null;

//    // ✅ Compare hashed password
//    if (!PasswordHelper.VerifyPassword(password, user.PasswordHash))
//        return null;

//    var token = _authUserRepo.CreateJobSeekerToken(user);

//    return new JobSeekerLoginDto
//    {
//        Id = user.Id,
//        FirstName = user.FirstName,
//        Email = user.Email,
//        Token = token
//    };
//}




