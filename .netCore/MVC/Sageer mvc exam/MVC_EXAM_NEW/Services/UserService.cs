using AutoMapper;
using MVC_EXAM_NEW.DTO;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repository;
        public readonly IMapper _mapper;

        public UserService (IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<UserDto> RegisterAsync(UserDto userdto, string password)
        {
            var user=_mapper.Map<User>(userdto);
            user.Password=password;
            await _repository.AddAsync(user);
            return _mapper.Map<UserDto>(user);
        }
        public async Task<UserDto> LoginAsync(string username, string password)
        {
            var user = await _repository.GetByUsernameAsync(username);
            if(user == null || user.Password!=password)
            {
                return null;
            }
            return _mapper.Map<UserDto>(user);
        }
    }
}
