//using System;
//using Domain.Enum;
//using Domain.Models;
//using Domain.Service.JobSeekker.Interfaces;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;


//namespace Domain.Service.Jobseeker
//{
//    public class JobSeekerRepository : IJobSeekerRepository
//    {
//        private readonly DbHireMeNowWebApiContext _context;

//        public JobSeekerRepository(DbHireMeNowWebApiContext context)
//        {
//            _context = context;
//        }
//        public async Task<bool> AddJobSeekerAsync(JobSeeker jobSeeker)
//        {
//            await _context.JobSeekers.AddAsync(jobSeeker);
//            var result = await _context.SaveChangesAsync();
//            return result > 0;
//        }
//        public async Task<JobSeeker?> GetByIdAsync(Guid id)
//        {
//            return await _context.JobSeekers.FindAsync(id);
//        }

//        public async Task<bool> UpdateAsync(JobSeeker jobSeeker)
//        {
//            _context.JobSeekers.Update(jobSeeker);
//            var result = await _context.SaveChangesAsync();
//            return result > 0;
//        }


//    }
//}

