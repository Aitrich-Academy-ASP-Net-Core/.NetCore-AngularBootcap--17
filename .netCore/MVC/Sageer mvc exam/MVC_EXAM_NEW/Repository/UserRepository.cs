using Microsoft.EntityFrameworkCore;
using MVC_EXAM_NEW.Data;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly CourseDBContext _dbContext;
        public UserRepository (CourseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task <User> GetByIdAsync(int id)
        {
            return await _dbContext.users.FindAsync(id);
        }
        public async Task <User> GetByUsernameAsync(string username)
        {
            return await _dbContext.users.FirstOrDefaultAsync(u => u.Username == username);
        }
        public async  Task AddAsync(User user)
        {
            _dbContext.users.Add(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
