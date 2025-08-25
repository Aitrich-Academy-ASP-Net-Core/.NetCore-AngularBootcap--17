using JobListingApp.Interface;
using JobListingApp.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BCrypt.Net;


namespace JobListingApp.Repository
{
    public class JobSeekerRepository:IJobSeekerRepository
    {
        private readonly ApplicationDbContext _context;

        public JobSeekerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<JobSeeker> RegisterAsync(JobSeeker jobSeeker)
        {
            _context.JobSeekers.Add(jobSeeker);
            await _context.SaveChangesAsync();
            return jobSeeker;
        }
        public async Task<JobSeeker?> GetByEmailAsync(string email)
        {
            return await _context.JobSeekers.FirstOrDefaultAsync(js => js.Email == email);
        }

        public async Task<JobSeeker> LoginAsync(string email, string password)
        {
            var seeker = await _context.JobSeekers.FirstOrDefaultAsync(j => j.Email == email);

            if (seeker != null && seeker.PasswordHash == password) // Replace with hashed comparison in real use
                return seeker;

            return null;
        }

        public async Task<bool> JobSeekerExistsAsync(string email)
        {
            return await _context.JobSeekers.AnyAsync(j => j.Email == email);
        }
    }
}
