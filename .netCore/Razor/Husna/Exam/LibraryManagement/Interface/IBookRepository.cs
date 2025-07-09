using LibraryManagement.Dto;
using LibraryManagement.Model;

namespace LibraryManagement.Interface
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task AddBookAsync(Bookdto bookdto);
        Task DeleteBookAsync(int id);
        Task<int> GetTotalBookCountAsync();
    }
}
