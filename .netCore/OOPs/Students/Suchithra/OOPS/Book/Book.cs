using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int year { get; set; }

        public Book()
        {
            Tittle = "Unknown";
            Author = "Unknown";
            Price = 0;
            year = 0;

        }

        public Book(string tittle, string author, int price, int year)
        {
            Tittle = tittle;
            Author = author;
            Price = price;
            this.year = year;
        }

        public void GetBookDetails()
        {
            Console.WriteLine("Book tittle:{0}",Tittle);
            Console.WriteLine("Author:{0}",Author);
            Console.WriteLine("price:{0},Year of publication:{1}",Price,year);

        }
    }

}
