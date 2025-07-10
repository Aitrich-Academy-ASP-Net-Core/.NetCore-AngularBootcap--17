using Library_Management.Interfaces;
using Library_Management.Models;
using Library_Management.Repository;
using Library_Management.DTO;

namespace Library_Management.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<User> ValidateUserAsync(UserDto dto)
        {
            return await _userRepo.GetUserAsync(dto.Username, dto.Password);
        }
    }
}
