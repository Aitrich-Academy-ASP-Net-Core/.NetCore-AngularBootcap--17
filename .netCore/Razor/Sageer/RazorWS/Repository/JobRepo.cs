using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RazorWS.DTO;
using RazorWS.Interface;
using RazorWS.Models;

namespace RazorWS.Repository
{
    public class JobRepo:IJobrepository
    {
        private readonly JobDBContext _context;
        private readonly IMapper _mapper;

        public JobRepo(JobDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<JobApplication>> GetAllJobAsync()
        {
            var job = await _context.Jobs.ToListAsync();
            return job;
        }
        public async Task AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<JobApplication>(jobDto);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }

        public async Task<JobApplication> GetJobByIdAsync( int id)
        {
            var jobs = await _context.Jobs.FindAsync();
            return _mapper.Map<JobApplication>(jobs);
        }

        public async Task UpdateJobAsync(int id, JobApplication jobDto)
        {
            var updatejob = await _context.Jobs.FindAsync(id);
            if (updatejob == null)
            {
                return;
            }
            _context.Entry(updatejob).State = EntityState.Detached;
            var upjob = _mapper.Map<JobApplication>(jobDto);
            upjob.id = id;
            _context.Jobs.Attach(upjob);
            _context.Entry(upjob).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJobAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if(job != null)
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
            }
        }

        
    }
}
