using AutoMapper;
using JOBPORTALNEW.Interface;
using JOBPORTALNEW.JobDto;
using JOBPORTALNEW.Model;

namespace JOBPORTALNEW.Service
{
    public class JobService:IService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public JobService(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // User 
        public async Task<UserDto> GetByUsernameAsync(string username)
        {
            var user = await _repository.GetUserByUsernameAsync(username);
            return _mapper.Map<UserDto>(user);
        }

        public async Task AddUserAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            await _repository.AddUserAsync(user);
        }

        public async Task<UserDto> LoginAsync(string username, string password)
        {
            var user = await _repository.LoginAsync(username, password);
            if (user == null)
                return null;

            return _mapper.Map<UserDto>(user);
        }

        // Job 
        public async Task<List<JobsDto>> GetAllJobsAsync()
        {
            var jobs = await _repository.GetAllJobsAsync();
            return _mapper.Map<List<JobsDto>>(jobs);
        }

        // Applied 
        public async Task ApplyToJobAsync(int jobId, int userId)
        {
            await _repository.ApplyToJobAsync(jobId, userId);
        }

        public async Task<List<AppliedDto>> GetAppliedJobsByUserIdAsync(int userId)
        {
            var appliedJobs = await _repository.GetAppliedJobsByUserIdAsync(userId);

            
            return _mapper.Map<List<AppliedDto>>(appliedJobs);
        }

    }
}
