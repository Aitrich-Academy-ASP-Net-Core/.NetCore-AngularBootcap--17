using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear {  get; set; }
        public bool IsAvailable {  get; set; }


        public Book(string tittle, string author,int publicationYear )
        {
            Title = tittle;     
            Author = author;
            PublicationYear = publicationYear;

                

        }
    }
}
