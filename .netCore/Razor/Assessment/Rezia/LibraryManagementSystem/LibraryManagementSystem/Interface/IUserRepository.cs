using AutoMapper;
using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.Interface
{
    public interface IUserRepository
    {

        public Task<User> GetUserByIdAsync(int id);

        public Task AddUserAsync(UserDto user);

 
    }
}
