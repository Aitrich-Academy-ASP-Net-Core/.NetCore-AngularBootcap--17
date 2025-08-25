using AutoMapper;
using JobListingApp.Dto;
using JobListingApp.Interface;
using JobListingApp.Model;

public class AuthService : IAuthService
{
    private readonly IJobSeekerRepository _jobSeekerRepo;
    private readonly IMapper _mapper;

    public AuthService(IJobSeekerRepository jobSeekerRepo, IMapper mapper)
    {
        _jobSeekerRepo = jobSeekerRepo;
        _mapper = mapper;
    }

    public async Task<JobSeekerDto> RegisterAsync(JobSeekerDto jobSeekerDto)
    {
        var jobSeeker = _mapper.Map<JobSeeker>(jobSeekerDto);

        // 🔒 Hash the password before saving
        jobSeeker.PasswordHash = BCrypt.Net.BCrypt.HashPassword(jobSeekerDto.Password);

        var createdSeeker = await _jobSeekerRepo.RegisterAsync(jobSeeker);
        return _mapper.Map<JobSeekerDto>(createdSeeker);
    }
    public async Task<bool> JobSeekerExistsAsync(string email)
    {
        var seeker = await _jobSeekerRepo.GetByEmailAsync(email);
        return seeker != null;
    }


    public async Task<JobSeekerDto?> AuthenticateAsync(string email, string password)
    {
        var seeker = await _jobSeekerRepo.GetByEmailAsync(email);

        // ✅ Use BCrypt to verify
        if (seeker != null && BCrypt.Net.BCrypt.Verify(password, seeker.PasswordHash))
        {
            return _mapper.Map<JobSeekerDto>(seeker);
        }

        return null;
    }
}
