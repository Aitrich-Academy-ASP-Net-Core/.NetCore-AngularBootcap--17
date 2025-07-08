using Mini_project.DTO;
using Mini_project.Models;

namespace Mini_project.Interfaces
{
    public interface ICompanyService
    {
        public Task<List<CompanyMember>> GetAllMemberAsync();
        public Task<CompanyMember> GetMemberbyidAsync(int id);
        public Task AddMemberAsync(MemberDto memberdto);
        public Task UpdateMemberAsync(int id, CompanyMember memberdto);
        public Task DeletememberAsync(int id);
    }
}
