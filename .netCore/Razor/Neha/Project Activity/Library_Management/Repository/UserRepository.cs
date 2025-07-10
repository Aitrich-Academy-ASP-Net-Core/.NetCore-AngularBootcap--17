using Library_Management.Interfaces;
using Microsoft.EntityFrameworkCore;
using Library_Management.Models;
using static Library_Management.Repository.UserRepository;

namespace Library_Management.Repository
{
    public class UserRepository:IUserRepo
    {
       
            private readonly LibraryDbContext _context;

            public UserRepository(LibraryDbContext context)
            {
                _context = context;
            }

            public async Task<User?> GetUserAsync(string username, string password)
            {
                return await _context.Users
                    .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            }
        }
    }


