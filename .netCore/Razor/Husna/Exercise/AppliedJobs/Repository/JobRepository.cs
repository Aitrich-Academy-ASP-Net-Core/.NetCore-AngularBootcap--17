using AppliedJobs.Dto;
using AppliedJobs.Interface;
using AppliedJobs.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace AppliedJobs.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public JobRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _context.Jobs.ToListAsync();
            return jobs;
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            return _mapper.Map<Job>(job); // Optional if mapping is needed
        }

        public async Task AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }

    }
}
