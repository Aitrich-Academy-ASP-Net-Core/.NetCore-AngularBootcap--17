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
        Task<AuthUser> GetByIdAsync(Guid id);
        Task<AuthUser> GetByEmailAsync(string email);
        Task<AuthUser> AddAsync(AuthUser user);
        Task UpdateAsync(AuthUser user);
        Task DeleteAsync(Guid id);
    }

}
