using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserRepository
    {
        Task<AuthUser> AddAuthUser(AuthUser authUser);

        Task<AuthUser> AdminLogin(string email, string password);
        string? CreateToken(AuthUser user);
        Task<AuthUser> GetAuthUserByUserEmail(string email);

        //Task<AuthUser> getUserByEmail(string? from);
    }
}
