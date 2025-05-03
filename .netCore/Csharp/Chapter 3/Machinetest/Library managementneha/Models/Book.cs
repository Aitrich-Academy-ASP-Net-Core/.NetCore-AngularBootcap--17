using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_managementneha.Models
{
    public class Book
    {
        public string Title { get;private set; }
        public string Author { get;private set; }
        public string ISBN { get;private set; }
        public int Quantity { get;internal set; }
        public Book(string title,string author,string isbn,int quantity)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Quantity = quantity;
        }
    }
}
