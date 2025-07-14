using AutoMapper;
using Microsoft.EntityFrameworkCore;
using  Workshop.Interfaces;
using Workshop.Models;
using Workshop.DTO;
namespace Workshop.Repository
{
    public class JobRepo : IJobrepository
    {
        private readonly JobDbContext _context;
        private readonly IMapper _mapper;

        public JobRepo(JobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var job = await _context.Jobs.ToListAsync();
            return job;

        }
        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            return _mapper.Map<Job>(job);
        }
        public async Task AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateJobAsync(int id, Job jobDto)
        {
            var updatejob = await _context.Jobs.FindAsync(id);
            if (updatejob==null)
            {
                return;
            }
            _context.Entry(updatejob).State = EntityState.Detached;
            var upjob = _mapper.Map<Job>(jobDto);
            upjob.Id = id;
            _context.Jobs.Attach(upjob); 
            _context.Entry(upjob).State = EntityState.Modified; 

            await _context.SaveChangesAsync();
        }
        public async Task DeleteJobAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job != null)
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
                
            }
        }



    }
}
