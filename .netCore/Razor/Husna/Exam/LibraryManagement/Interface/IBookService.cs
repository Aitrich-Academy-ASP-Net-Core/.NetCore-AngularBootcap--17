using LibraryManagement.Dto;
using LibraryManagement.Model;

namespace LibraryManagement.Interface
{
    public interface IBookService
    {
        public Task<List<Book>> GetAllBooksAsync();
        public Task AddBookAsync(Bookdto bookdto);
        public Task DeleteBookAsync(int id);
        Task<int> GetTotalBookCountAsync();
    }
}
