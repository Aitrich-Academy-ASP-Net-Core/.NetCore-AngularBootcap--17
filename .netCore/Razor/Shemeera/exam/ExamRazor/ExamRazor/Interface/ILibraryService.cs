using ExamRazor.LIbraryDto;
using ExamRazor.Model;

namespace ExamRazor.Interface
{
    public interface ILibraryService
    {
        Task<User> LoginAsync(string username, string password);
        Task<bool> RegisterUserAsync(User user);

        
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task AddBookAsync(Book book);
        
        Task DeleteBookAsync(int id);
    }





}

