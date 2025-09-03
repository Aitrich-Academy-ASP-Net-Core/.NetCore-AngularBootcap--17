using JobPortal.Dto;

namespace JobPortal.Interface
{
    public interface IUserService
    {

        Task<UserDto> RegisterUserAsync(UserRegisterDto userRegisterDto);
        Task<UserDto> LoginUserAsync(UserLoginDto userLoginDto);
        Task<UserDto> GetUserByIdAsync(int id);


    }
}
