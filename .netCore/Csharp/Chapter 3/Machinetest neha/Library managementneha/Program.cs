using Library_managementneha.Models;
using Library_managementneha.Services;

namespace Library_managementneha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryServices library = new LibraryServices();
            bool exist = false;
            while (!exist)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Display Books");
                Console.WriteLine("3.Borrow Book");
                Console.WriteLine("4.Remove Book");
                Console.Write("Enter a choice: ");
                try
                {
                    int Choice = int.Parse(Console.ReadLine());
                    switch (Choice)
                    {
                        case 1:
                            Console.Write("Title:");
                            string title2 = Console.ReadLine();
                            Console.Write("Author:");
                            string author2 = Console.ReadLine();
                            Console.Write("ISBN:");
                            string isbn2 = Console.ReadLine();
                            Console.Write("Quantity:");
                            int qty = int.Parse(Console.ReadLine());
                            Book book = new Book(title2, author2, isbn2, qty);
                            library.DisplayAdd(book);
                            break;
                        case 2:
                            Console.WriteLine("\nBooks are:");
                            library.DisplayBook();

                            break;
                        case 3:
                            Console.WriteLine("Enter ISBN of borrowed book :");
                            string borrowed2 = Console.ReadLine();
                            library.DisplayBorrow(borrowed2);
                            break;
                        case 4:
                            Console.WriteLine("Enter ISBN: ");
                            string checkisbn = Console.ReadLine();
                            library.DisplayRemove(checkisbn);
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error message :{ex.Message}");
                }
            }
        }
    }
}


