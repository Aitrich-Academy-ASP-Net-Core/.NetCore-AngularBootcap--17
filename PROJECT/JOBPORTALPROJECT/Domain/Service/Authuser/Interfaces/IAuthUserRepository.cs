using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserRepository
    {


        //Task<AuthUser> AddAuthUser(AuthUser authUser);
        Task<AuthUser> GetAuthUserByUserEmail(string email);
        //Task<AuthUser> GetAuthUserByUserId(Guid id);
        //Task<AuthUser> ValidateUserAsync(string email, string password);
        string CreateToken(AuthUser user);
        //Task<CompanyUser> GetUser(Guid userId);
        Task<CompanyUser?> GetUser(Guid userId);
        Task<AuthUser> ValidateUserAsync(string email, string password);

        //Task<AuthUser> AddAuthUser(AuthUser authUser);

        //// Add new Job Provider / Company User
        //Task<AuthUser> AddAuthUserJP(AuthUser authUser);

        //// Create JWT token for AuthUser
        //string CreateToken(AuthUser user);


        //string CreateJobSeekerToken(AuthUser jobSeeker);

        //// Get Company User by Id
        //Task<CompanyUser> GetUser(Guid userId);

        //// Admin login
        //Task<AuthUser> AdminLogin(string email, string password);
        //// Get AuthUser by Email
        //Task<AuthUser> GetAuthUserByUserEmail(string email);

        //// Get AuthUser by Id
        //Task<AuthUser> GetAuthUserByUserId(Guid authUserId);

        //// Add/update SignalR connection Id
        ////Task AddUserConnectionIdAsync(string email, string connectionId);

        //// Get AuthUser by ConnectionId
        //Task<AuthUser> GetUserByConnectionIdAsync(string connectionId);

        //// Disconnect user by connectionId
        ////Task DisconnectUserByConnectionIdAsync(string connectionId);
    }

}
