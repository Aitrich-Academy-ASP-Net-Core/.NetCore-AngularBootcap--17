using AppliedJobs.Dto;
using AppliedJobs.Interface;
using AppliedJobs.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace AppliedJobs.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterUserAsync(User user)
        {
            var exists = await _context.Users
                .AnyAsync(u => u.Username == user.Username || u.Email == user.Email);

            if (exists)
                return false;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
