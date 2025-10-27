using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Login.Interfaces;

using Domain.Helpers;
using Domain.Models;

using System.Linq;

namespace Domain.Service.Login
{
    public class LoginRequestRepository : ILoginRequestRepository
    {
        protected readonly AppDbContext _context;
        public LoginRequestRepository(AppDbContext dbContext)
        {
            _context = dbContext;
        }


        public AuthUser GetUserByEmail(string email)
        {
            return _context.AuthUsers.FirstOrDefault(u => u.Email == email);
        }

        // Validate login with email + password
        public AuthUser GetUserByEmailPassword(string email, string password)
        {
            var user = _context.AuthUsers.FirstOrDefault(u => u.Email == email);
            if (user == null) return null;

            // Verify hashed password
            if (!PasswordHelper.VerifyPassword(password, user.PasswordHash))
                return null;

            return user;
        }


        //public AuthUser GetUserByEmail(string email)
        //{
        //    return _context.AuthUsers.FirstOrDefault(e => e.Email == email);
        //}

        //public AuthUser GetUserByEmailpassword(string email, string password)
        //{
        //    var user = _context.AuthUsers.FirstOrDefault(e => e.Email == email);
        //    if (user == null) return null;

        //    // ✅ Compare hashed passwords properly
        //    if (!PasswordHelper.VerifyPassword(password, user.PasswordHash))
        //        return null;

        //    return user;
        //}
    }
}


