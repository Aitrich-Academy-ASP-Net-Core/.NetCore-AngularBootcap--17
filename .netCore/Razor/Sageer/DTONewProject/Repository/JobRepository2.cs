using DTONewProject.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using DTONewProject.Models;
using DTONewProject.DTO;


namespace DTONewProject.Repository
{
    public class JobRepository2:Jobrepository
    {
        private readonly JobDBContext _context;
        private readonly IMapper _mapper;

        public JobRepository2(JobDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Job> AddJobByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _context.Jobs.ToListAsync();
            return jobs;
        }
        public async Task GetJobByIdAsync( JobDTO jobDTO)
        {
            var job = _mapper.Map<Job>(jobDTO);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }

    }
}
