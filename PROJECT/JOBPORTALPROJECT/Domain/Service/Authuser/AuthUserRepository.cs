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

        public async Task<AuthUser> GetByEmailAsync(string email)
        {
            return await _context.AuthUsers
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task AddAsync(AuthUser user)
        {
            _context.AuthUsers.Add(user);
            await _context.SaveChangesAsync();
        }
    }


}
