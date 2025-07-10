using Library_Management.Models;

namespace Library_Management.Interfaces
{
    public interface IUserRepo
    {
        Task<User> GetUserAsync(string username, string password);
    }
}
