using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    internal class Book
    {
        public string ? Title { get; set; }
        public string ? Author { get; set; }
        public string ? Price { get; set; }
        public string? PublicationYear { get; set; }

        public void BookDetails()
        {
            Console.WriteLine("Title : {0}",Title);
            Console.WriteLine("Autor : {0}", Author);
            Console.WriteLine("Price : {0}", Price);
            Console.WriteLine("Publication Year : {0}", PublicationYear);
        }

        public Book()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
            Price = "Rs. 250/-";
            PublicationYear = "Sep 2022";
        
        }

        public Book(string? title, string? author, string? price, string? publicationYear)
        {
            Title = title;
            Author = author;
            Price = price;
            PublicationYear = publicationYear;
        }
    }
}
