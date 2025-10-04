using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Authuser.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Domain.Service.Authuser
{

    public class AuthUserRepository : IAuthUserRepository
    {
        private readonly AppDbContext _context;

        public AuthUserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AuthUser> GetByIdAsync(Guid id)
        {
            return await _context.AuthUsers.FindAsync(id);
        }

        public async Task<AuthUser> GetByEmailAsync(string email)
        {
            return await _context.AuthUsers
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<AuthUser> AddAsync(AuthUser user)
        {
            await _context.AuthUsers.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task UpdateAsync(AuthUser user)
        {
            _context.AuthUsers.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _context.AuthUsers.FindAsync(id);
            if (user != null)
            {
                _context.AuthUsers.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }


}
