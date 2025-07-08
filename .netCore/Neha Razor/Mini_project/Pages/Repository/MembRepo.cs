using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Mini_project.DTO;
using Mini_project.Interfaces;
using Mini_project.Models;

namespace Mini_project.Pages.Repository
{
    public class MembRepo : ICompanyRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MembRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CompanyMember>> GetAllMemberAsync()
        {
            return await _context.CompanyMembers.ToListAsync();
        }

        public async Task<CompanyMember> GetMemberbyidAsync(int id)
        {
            return await _context.CompanyMembers.FindAsync(id);
        }

        public async Task AddMemberAsync(MemberDto memberdto)
        {
            var job = _mapper.Map<CompanyMember>(memberdto);
            _context.CompanyMembers.Add(job);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMemberAsync(int id, CompanyMember memberdto)
        {
            var updatemember = await _context.CompanyMembers.FindAsync(id);
            if (updatemember == null)
            {
                return;
            }
            _context.Entry(updatemember).State = EntityState.Detached;
            var upmember = _mapper.Map<CompanyMember>(memberdto);
            upmember.MemberId = id;
            _context.CompanyMembers.Attach(upmember);
            _context.Entry(upmember).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task DeletememberAsync(int id)
        {
            var company = await _context.CompanyMembers.FindAsync(id);
            if (company == null) return;

            _context.CompanyMembers.Remove(company);
            await _context.SaveChangesAsync();
        }
    }
}
