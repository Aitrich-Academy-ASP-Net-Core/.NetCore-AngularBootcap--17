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
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using static Domain.Service.Authuser.Interfaces.IAuthUserService;

namespace Domain.Service.Authuser
{
    public class AuthUserService : IAuthUserService
    {


        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAuthUserRepository _userRepository;

        public AuthUserService(IHttpContextAccessor httpContextAccessor, IAuthUserRepository userRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
        }

        public string GetUserId()
        {
            if (_httpContextAccessor.HttpContext == null) return null;
            return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid)?.Value;
        }

        public async Task<CompanyUser> GetCompanyUserAsync(Guid userId)
        {
            return await _userRepository.GetUser(userId);
        }


        //private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly IAuthUserRepository _userRepository;

        //public AuthUserService(IHttpContextAccessor httpContextAccessor, IAuthUserRepository userRepository)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //    _userRepository = userRepository;
        //}

        //public string GetUserId()
        //{
        //    var result = string.Empty;
        //    if (_httpContextAccessor.HttpContext != null)
        //    {
        //        result = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value.ToString();
        //    }
        //    return result;
        //}
        //public async Task<CompanyUser> GetUserAsync(Guid userId)
        //{
        //    // Call repository async method properly
        //    var user = await _userRepository.GetUser(userId);
        //    return user;
        //}

    }
}
