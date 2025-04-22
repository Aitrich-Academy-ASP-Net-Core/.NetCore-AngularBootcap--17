using System;
using LibraryManagement.Managers;
internal class Public
{
public static LibraryManager library=new LibraryManager();
    public static void Main(string[] args)


    {
        Console.WriteLine("Welcome to the Library Management System!");
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Borrow a Book");
            Console.WriteLine("2. Return a Book");
            Console.WriteLine("3. View Borrowing History");
            Console.WriteLine("4. View Inventory Status");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                  library. BorrowBook();
                    break;
                case "2":
                    library.ReturnBook();
                    break;
                case "3":
                    library.ViewBorrowingHistory();
                    break;
                case "4":
                    library.ViewInventory();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Library Management System. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}

