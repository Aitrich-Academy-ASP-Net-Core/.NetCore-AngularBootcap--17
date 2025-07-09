using ExamRazor.Model;

namespace ExamRazor.Interface
{
    public interface ILibraryRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task AddUserAsync(User user);

        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task AddBookAsync(Book book);
        
        Task DeleteBookAsync(int id);
    }
}
