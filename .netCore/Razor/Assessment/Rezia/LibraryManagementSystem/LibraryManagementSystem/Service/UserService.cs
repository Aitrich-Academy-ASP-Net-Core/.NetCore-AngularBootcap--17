using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Repository;

namespace LibraryManagementSystem.Service
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _repository.GetUserByIdAsync(id);
        }
        public async Task AddUserAsync(UserDto userDto)
        {
            await _repository.AddUserAsync(userDto);
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
          return  await _repository.GetUserByEmailAsync(email);
        }
    }
}
