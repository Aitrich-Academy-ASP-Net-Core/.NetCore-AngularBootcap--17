using JobSeekerManagement.Dto;
using JobSeekerManagement.Models;

namespace JobSeekerManagement.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int id);        // For fetching a user by id

        Task UpdateAsync(User user);             // For Profile Update

    }
}
