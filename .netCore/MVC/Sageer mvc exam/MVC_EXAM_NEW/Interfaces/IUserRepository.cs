using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task <User> GetByUsernameAsync(string username);
        Task AddAsync(User user);
    }
}
