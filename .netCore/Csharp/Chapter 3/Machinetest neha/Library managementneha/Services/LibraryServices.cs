using Library_managementneha.Interfaces;
using Library_managementneha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_managementneha.Services
{
   public class LibraryServices:ILibraryprocess
    {
        private List<Book> book1 = new List<Book>();
        public void DisplayAdd(Book book)
        {
            book1.Add(book);
            Console.WriteLine("Book added successfully");
        }
        public void DisplayRemove(string isbn)
        {
            Book book = book1.Find(b => b.ISBN == isbn);
            if (book1==null)
            {
                throw new Exception("Invalid ISBN");
            }
            else
            {
                book1.Remove(book);
                Console.WriteLine("Book successfully removed");
            }
        }
        public void DisplayBorrow(string isbn)
        {
            Book book = book1.Find(b => b.ISBN == isbn);
            if (book == null)
            {
                throw new Exception("Book not found");
                if (book.Quantity <= 0)

                    throw new Exception("Book out of stock");
            }
               
                    book.Quantity--;

                
            }
           
        
        public void DisplayBook()
        {
            if (book1.Count==0)
            {
                Console.WriteLine("No books are available");
                return;
            }
            else
            {
                Console.WriteLine("Available books are : ");
                foreach (var item in book1)
                {
                    Console.WriteLine($"Title:{item.Title}-Author:{item.Author},Quantity:{item.Quantity}");
                }
            }
        }
    }
}
