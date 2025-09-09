using JobSeekerManagement.Models;
using JobSeekerManagement.Dto;
namespace JobSeekerManagement.Interface
{
    public interface IPublicService
    {
        Task RegisterAsync(UserDto userDto);
        Task<UserDto> LoginAsync(string email, string password);
        
    }
}
