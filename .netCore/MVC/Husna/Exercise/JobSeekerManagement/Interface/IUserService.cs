using JobSeekerManagement.Dto;
namespace JobSeekerManagement.Interface
{
    public interface IUserService
    {
        Task<ProfileDto> GetProfileAsync(int userId);
        Task<bool> UpdateProfileAsync(ProfileDto profileDto);

    }
}

