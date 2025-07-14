using System.Runtime.InteropServices;
using AutoMapper;
using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Interface;
using LibraryManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<User> GetUserByIdAsync(int id)
        {
            var userid = await _context.Users.FindAsync(id);
            return _mapper.Map<User>(userid);
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x=>x.UserEmail == email);
        }
        public async Task AddUserAsync(UserDto userDto)
        {
            var newuser = _mapper.Map<User>(userDto);
            await _context.Users.AddAsync(newuser);
            await _context.SaveChangesAsync();
        }
    }
}
