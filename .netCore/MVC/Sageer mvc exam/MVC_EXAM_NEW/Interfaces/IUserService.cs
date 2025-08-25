using MVC_EXAM_NEW.DTO;

namespace MVC_EXAM_NEW.Interfaces
{
    public class IUserService
    {
        Task<UserDto> RegisterAsync(UserDto userdto, string password);
        Task<UserDto> LoginAsync(string username, string password);
    }
}
