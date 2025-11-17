using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
   public static class PasswordHelper
    {

        private static readonly PasswordHasher<AuthUser> _passwordHasher = new();

        // ✅ Hash password before saving to DB
        public static string HashPassword(AuthUser user, string password)
        {
            return _passwordHasher.HashPassword(user, password);
        }

        // ✅ Verify password during login
        public static bool VerifyPassword(AuthUser user, string enteredPassword)
        {
            if (user.Password == null)
                return false;

            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, enteredPassword);
            return result == PasswordVerificationResult.Success;
        }
    }

    
}
