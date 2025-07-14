using AutoMapper;
using Microsoft.AspNetCore.Builder;
using RazorExerciseNew.Models;
using RazorExerciseNew.DTO;
using Microsoft.EntityFrameworkCore;

namespace RazorExerciseNew.Repository
{
    public class Jobrepo
    {
        private readonly JobDBContext _context;
        private readonly IMapper _mapper;

        public Jobrepo(JobDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Application>> GetAllJobAsync()
        {
            var job = await _context.Applications.ToListAsync();
            return job;
        }
        public async Task AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Application>(jobDto);
            _context.Applications.Add(job);
            await _context.SaveChangesAsync();
        }

        public async Task<Application> GetJobByIdAsync(int id)
        {
            var jobs = await _context.Jobs.FindAsync();
            return _mapper.Map<Application>(jobs);
        }

        public async Task UpdateJobAsync(int id, Applications jobDto)
        {
            var updatejob = await _context.Applications.FindAsync(id);
            if (updatejob == null)
            {
                return;
            }
            _context.Entry(updatejob).State = EntityState.Detached;
            var upjob = _mapper.Map<Application>(jobDto);
            upjob.id = id;
            _context.Applications.Attach(upjob);
            _context.Entry(upjob).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJobAsync(int id)
        {
            var job = await _context.Applications.FindAsync(id);
            if (job != null)
            {
                _context.Applications.Remove(job);
                await _context.SaveChangesAsync();
            }
        }
    }

    internal class JobDBContext
    {
    }
}
