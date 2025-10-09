using AutoMapper;
using Domain.Enums;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Authuser
{
    public class AuthUserRepository : IAuthUserRepository
    {
        protected readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthUserRepository(AppDbContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _context = dbContext;
            _mapper = mapper;
            _configuration = configuration;
        }

        // =================== Add Job Seeker ===================
        public async Task<AuthUser> AddAuthUser(AuthUser authUser)
        {
            authUser.Role = Role.JOB_SEEKER;
            await _context.AuthUsers.AddAsync(authUser);

            var jobSeeker = _mapper.Map<JobSeeker>(authUser);
            await _context.JobSeekers.AddAsync(jobSeeker);

            var jp = new JobSeekerProfile { JobSeekerId = jobSeeker.Id };
            await _context.JobSeekerProfiles.AddAsync(jp);

            await _context.SaveChangesAsync();
            return authUser;
        }

        // =================== Add Job Provider (Company User) ===================
        public async Task<AuthUser> AddAuthUserJP(AuthUser authUser)
        {
            authUser.Role = Role.JOB_PROVIDER;
            await _context.AuthUsers.AddAsync(authUser);

            var companyUser = _mapper.Map<CompanyUser>(authUser);
            await _context.CompanyUsers.AddAsync(companyUser);

            await _context.SaveChangesAsync();
            return authUser;
        }

        // =================== Create JWT Token ===================
        public string CreateToken(AuthUser user)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.FirstName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Sid, user.Id.ToString()),
            new Claim(ClaimTypes.Role, "Admin") // match [Authorize(Roles="Admin")]
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["AuthSettings:Token"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // =================== Get Company User by Id ===================
        public async Task<CompanyUser> GetUser(Guid userId)
        {
            return await _context.CompanyUsers.FirstOrDefaultAsync(u => u.Id == userId);
        }

        // =================== Admin Login ===================
        public async Task<AuthUser> AdminLogin(string email, string password)
        {
            var user = await _context.AuthUsers
                .FirstOrDefaultAsync(u => u.Email == email && u.Role == Role.ADMIN);

            if (user == null) return null;

            // Plain password comparison for now
            if (user.Password != password) return null;

            return user;
        }

        // =================== Get AuthUser by Email ===================
        public async Task<AuthUser> GetAuthUserByUserEmail(string email)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(u => u.Email == email);
        }

        // =================== Get AuthUser by Id ===================
        public async Task<AuthUser> GetAuthUserByUserId(Guid authUserId)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(u => u.Id == authUserId);
        }

        // =================== Add Connection Id (Chat) ===================
        public async Task AddUserConnectionIdAsync(string email, string connectionId)
        {
            var user = await _context.AuthUsers.FirstOrDefaultAsync(u => u.Email == email);
            if (user != null)
            {
                user.ConnectionId = connectionId;
                user.OnlineStatus = true;
                _context.AuthUsers.Update(user);
                await _context.SaveChangesAsync();
            }
        }

        // =================== Get AuthUser by ConnectionId ===================
        public async Task<AuthUser> GetUserByConnectionIdAsync(string connectionId)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(u => u.ConnectionId == connectionId);
        }

        // =================== Disconnect User (Chat) ===================
        public async Task DisconnectUserByConnectionIdAsync(string connectionId)
        {
            var user = await _context.AuthUsers.FirstOrDefaultAsync(u => u.ConnectionId == connectionId);
            if (user != null)
            {
                user.ConnectionId = "";
                user.OnlineStatus = false;
                _context.AuthUsers.Update(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}

