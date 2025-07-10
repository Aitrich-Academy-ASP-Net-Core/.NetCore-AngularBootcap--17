using Library_Management.DTO;
using Library_Management.Models;

namespace Library_Management.Interfaces
{
    public interface IUserService
    {
        Task<User> ValidateUserAsync(UserDto dto);
    }
}
