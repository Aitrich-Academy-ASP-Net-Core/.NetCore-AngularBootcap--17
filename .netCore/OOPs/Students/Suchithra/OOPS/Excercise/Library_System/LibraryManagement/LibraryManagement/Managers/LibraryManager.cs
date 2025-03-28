using LibraryManagement.Interfaces;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Managers
{
    internal class LibraryManager : IInventoryManager,IBorrowing
    {

       
        private BorowingRecord[] borowings=new BorowingRecord[100] ;
        public int BorowingCount = 0;
        string searchTerm;

        Book[] books = new Book[] { new Book("C# Programming", "John Smith", 2020),
            new Book("Java Programming", "Jane Doe", 2019),
        new Book(".Net Prigramming","John Antony",2021),
          new  Book("Basics of programming","Andrews",2014)};

        public void IsBookAvailable(string Tittle)
        {
            Console.WriteLine("Enter book tittle");
            string title=Console.ReadLine();
            Console.WriteLine("Enter Author name");
            string author=Console.ReadLine();
           
            foreach (Book book in books) {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Book is available");
                    
                }
                else
                {
                    Console.WriteLine("Sorry book is not found!!!");
                   
                   
                }
                
            }
           
        }

        public void ViewInventory()
        {
            Console.WriteLine("Current inventory status...");
            foreach (Book book in books) 
            {
                string status = book.IsAvailable ? "Available" : "Borrowed";
                Console.WriteLine($"- \"{book.Title}\" by {book.Author} ({book.PublicationYear}) - {status}");
            }
        }

        public void BorrowBook()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your membership ID: ");
            string membershipId = Console.ReadLine();
            Console.Write("Enter the book title: ");
            string bookTitle = Console.ReadLine();


            Console.Write("Enter the publication year: ");
            string inputYear = Console.ReadLine();
            if (!int.TryParse(inputYear, out int publicationYear) || publicationYear <= 0 || publicationYear > DateTime.Now.Year)
            {
                Console.WriteLine($"Invalid publication year. Please enter a year between 1 and {DateTime.Now.Year}.");
                return;
            }
            if (IsBookAvailabeForBorrowing (bookTitle)) 
            {
                MarkAsBorrowed(bookTitle);
                borowings[BorowingCount] = new BorowingRecord(userName, membershipId, bookTitle, DateTime.Now);
                BorowingCount++;
                Console.WriteLine($"{userName}, you have successfully borrowed \"{bookTitle}\" on {DateTime.Now:MM/dd/yyyy}.");
            



        }
        }

        public void ReturnBook()
        {
            Console.Write("Enter your membership ID: ");
            string membershipId = Console.ReadLine();
            Console.Write("Enter the book title: ");
            string bookTitle = Console.ReadLine();

            if (MarkAsReturned(bookTitle))
            
            {
                foreach (BorowingRecord borowingRecord in borowings) 
                {
                    if (borowingRecord != null && borowingRecord.MemberShipId == membershipId && borowingRecord.ReturnDate == null)
                    {
                        borowingRecord.ReturnDate = DateTime.Now;
                        Console.WriteLine($"Successfully returned \"{bookTitle}\" on {DateTime.Now:MM/dd/yyyy}.");
                        return;

                    }
                
                }
            
            
            }
            else
            {
                Console.WriteLine("Return failed. Either the book is not borrowed or the details are incorrect.");
            }
        }

        public void ViewBorrowingHistory()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"\nBorrowing History for {userName}:");
            bool found = false;

            foreach (var record in borowings)
            {
                if (record != null && record.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"- \"{record.BookTttle}\" - Borrowed on: {record.BorrowingDate:MM/dd/yyyy}, " +
                                      $"Returned on: {(record.ReturnDate.HasValue ? record.ReturnDate.Value.ToString("MM/dd/yyyy") : "Not yet returned")}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No borrowing history found.");
            }
        }

        public bool IsBookAvailabeForBorrowing(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && book.IsAvailable)
                {
                    return true;
                }

            }
            Console.WriteLine($"The book \"{title}\" is not available for borrowing.");
            return false;


        }


        public void MarkAsBorrowed(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.IsAvailable = false;
                    return;
                }
            }
        }


        public bool MarkAsReturned(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && !book.IsAvailable)
                {
                    book.IsAvailable = true;
                    return true;
                }
            }
            return false;
        }
    }
        }
    

