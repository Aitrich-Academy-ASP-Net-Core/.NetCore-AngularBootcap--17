using MVC_Register.Models;
namespace MVC_Register.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
    }
}
