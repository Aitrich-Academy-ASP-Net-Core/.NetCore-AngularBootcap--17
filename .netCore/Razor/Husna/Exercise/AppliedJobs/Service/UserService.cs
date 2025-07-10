using AppliedJobs.Model;
using AppliedJobs.Repository;
using AppliedJobs.Dto;
using AppliedJobs.Interface;
using AppliedJobs.Extension;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace AppliedJobs.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> RegisterUserAsync(User user)
        {
            return await _userRepository.RegisterUserAsync(user);
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            return await _userRepository.LoginAsync(username, password);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }
    }
}
