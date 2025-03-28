using System;
namespace Book
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            book2.Tittle = "Science Miracle";
            book2.Author = "James";
            book2.Price = 1078;
            book2.year = 2023;

            book1.GetBookDetails();
            book2.GetBookDetails();
            Book book3=new Book("Developer Jorney","Antony varghees",2000,2024);
            book3.GetBookDetails();

           
            
        }
    }
}
