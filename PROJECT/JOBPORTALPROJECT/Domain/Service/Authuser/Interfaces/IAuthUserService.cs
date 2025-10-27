using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Authuser.Dto;
using static Domain.Service.Authuser.Interfaces.IAuthUserService;

namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserService
    {
        string GetUserId();
        
        Task<CompanyUser> GetCompanyUserAsync(Guid userId);
    }
}

