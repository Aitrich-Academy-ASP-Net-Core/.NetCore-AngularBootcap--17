using AutoMapper;
using Mini_project.DTO;
using Mini_project.Interfaces;
using Mini_project.Models;
using Mini_project.Pages.Repository;

namespace Mini_project.Pages.Services
{
    public class MembService:ICompanyService
    {
        private readonly MembRepo _membservice;
        private readonly IMapper _mapper;
        public MembService(MembRepo membservice, IMapper mapper)
        {
            _membservice = membservice;
             _mapper = mapper;
        }
        public async Task<List<CompanyMember>> GetAllMemberAsync()
        {
            return await _membservice.GetAllMemberAsync();
        }
        public async Task<CompanyMember> GetMemberbyidAsync(int id)
        {
            return await _membservice.GetMemberbyidAsync(id);
        }
        public async Task AddMemberAsync(MemberDto memberdto)
        {
            await _membservice.AddMemberAsync(memberdto);
        }
        public async Task UpdateMemberAsync(int id, CompanyMember memberdto)
        {
            await _membservice.UpdateMemberAsync(id, memberdto);
        }
        public async Task DeletememberAsync(int id)
        {
            await _membservice.DeletememberAsync(id);
        }

        
    }
}
