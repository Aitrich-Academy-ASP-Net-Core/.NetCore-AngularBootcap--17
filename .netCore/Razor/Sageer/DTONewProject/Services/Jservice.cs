using AutoMapper;
using DTONewProject.DTO;
using DTONewProject.Interfaces;
using DTONewProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DTONewProject.Services
{
    public class Jservice : IJobService
    {
        
   

            
            // Your logic...
        
        private readonly JobDBContext _context;
        private readonly IMapper _mapper;

        public Jservice(JobDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _context.Jobs.ToListAsync();
            return jobs;
        }
        public async Task AddJobAsync(JobDTO jobDTO)
        {
            var job = _mapper.Map<Job>(jobDTO);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }
        
        private Exception NotImplementedException()
        {
            throw new NotImplementedException();
        }

        public Task<Job> AddJobByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
