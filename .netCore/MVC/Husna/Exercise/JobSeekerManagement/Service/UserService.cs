using AutoMapper;
using JobSeekerManagement.Dto;
using JobSeekerManagement.Models;
using JobSeekerManagement.Interface;


namespace JobSeekerManagement.Service
{
    using AutoMapper;
    using JobSeekerManagement.Dto;
    using JobSeekerManagement.Interface;
    using JobSeekerManagement.Models;
    using Microsoft.EntityFrameworkCore;

    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ProfileDto> GetProfileAsync(int userId)
        {
            var user = await _repo.GetByIdAsync(userId);
            return _mapper.Map<ProfileDto>(user);
        }

        public async Task<bool> UpdateProfileAsync(ProfileDto profileDto)
        {
            if (profileDto == null)
                throw new ArgumentNullException(nameof(profileDto));

            var user = await _repo.GetByIdAsync(profileDto.UserId);
            if (user == null)
                throw new KeyNotFoundException($"User with ID {profileDto.UserId} not found.");

            _mapper.Map(profileDto, user);
            await _repo.UpdateAsync(user);
            return true;
        }

    }

}
