using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Authuser.Dto;
using Domain.Service.Authuser.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Service.Authuser
{
    public class AuthUserService : IAuthUserService
    {
        private readonly IAuthUserRepository _repo;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;

        public AuthUserService(IAuthUserRepository repo, IMapper mapper, IConfiguration configuration)
        {
            _repo = repo;
            _mapper = mapper;
            _config = configuration;
        }

        public async Task<AuthUserDTO> LoginAsync(LoginRequestDTO loginRequest)
        {
            var user = await _repo.GetByEmailAsync(loginRequest.Email);
            if (user == null)
                throw new Exception("User not found");

            // Verify password (you should use hashing + salt)
            if (user.Password != loginRequest.Password)
                throw new Exception("Invalid credentials");

            // Generate token
            string token = CreateToken(user);

            // Map to DTO and return
            var dto = _mapper.Map<AuthUserDTO>(user);
            dto.Token = token;
            return dto;
        }

        public async Task<AuthUserDTO> SignupAsync(SignupRequestDTO signupRequest, string password)
        {
            // Check if email exists
            var existing = await _repo.GetByEmailAsync(signupRequest.Email);
            if (existing != null)
                throw new Exception("Email already registered");

            AuthUser user = new AuthUser
            {
                FirstName = signupRequest.FirstName,
                LastName = signupRequest.LastName,
                Email = signupRequest.Email,
                Role = signupRequest.Role,
                Password = password  // In real scenario, you hash this
            };

            var created = await _repo.AddAsync(user);

            var dto = _mapper.Map<AuthUserDTO>(created);
            dto.Token = CreateToken(created);
            return dto;
        }

        public async Task<AuthUserDTO> GetUserByIdAsync(Guid id)
        {
            var user = await _repo.GetByIdAsync(id);
            if (user == null)
                return null;
            return _mapper.Map<AuthUserDTO>(user);
        }

        public async Task<bool> UpdateProfileAsync(AuthUserDTO updatedUser)
        {
            var user = await _repo.GetByIdAsync(updatedUser.Id);
            if (user == null)
                return false;

            user.FirstName = updatedUser.FirstName;
            user.LastName = updatedUser.LastName;
            // ... other updates

            await _repo.UpdateAsync(user);
            return true;
        }

        // Helper: create JWT token
        private string CreateToken(AuthUser user)
        {
            var tokenSecret = _config["AuthSettings:Token"];
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSecret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Sid, user.Id.ToString()),
            new Claim(ClaimTypes.Role, user.Role),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.FirstName)
        };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
