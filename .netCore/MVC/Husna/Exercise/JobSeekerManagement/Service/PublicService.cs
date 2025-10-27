using AutoMapper;
using JobSeekerManagement.Dto;
using JobSeekerManagement.Interface;
using JobSeekerManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace JobSeekerManagement.Service
{
    public class PublicService : IPublicService
    {
        private readonly IPublicRepository _repository;
        private readonly IMapper _mapper;

        public PublicService(IPublicRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task RegisterAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _repository.RegisterAsync(user);
        }

        public async Task<UserDto?> LoginAsync(string email, string password)
        {
            var user = await _repository.LoginAsync(email, password);
            if (user == null)
                return null;

            return _mapper.Map<UserDto>(user);
        }



    }
}
