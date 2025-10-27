using System;
using System.Security.Cryptography;
using System.Text;
using MassTransit.Futures.Contracts;

namespace Domain.Helpers
{

    public static class PasswordHelper
    {

        public static string HashPassword(string password)
        {
            // Always use BCrypt to hash
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            if (string.IsNullOrWhiteSpace(hashedPassword))
                return false;

            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}  



