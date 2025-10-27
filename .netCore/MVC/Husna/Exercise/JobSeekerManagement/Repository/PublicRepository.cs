using JobSeekerManagement.Interface;
using JobSeekerManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace JobSeekerManagement.Repository
{
    public class PublicRepository : IPublicRepository
    {
        private readonly AppDbContext _context;

        public PublicRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task RegisterAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        }


    }
}
