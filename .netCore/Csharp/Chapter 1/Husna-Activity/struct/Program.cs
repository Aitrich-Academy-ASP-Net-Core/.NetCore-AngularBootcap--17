
//using System;

//namespace EmployeeRecords
//{
//    class Program
//    {
//        struct Employee
//        {
//            public int EmployeeID;
//            public string Name;
//            public double Salary;
//        }

//        static void Main()
//        {
//            Employee[] employees = new Employee[5];

//            // Input Employee Details
//            for (int i = 0; i < employees.Length; i++)
//            {
//                Console.WriteLine("Enter details for Employee " + (i + 1) + ":");


//                Console.Write("Employee ID: ");
//                employees[i].EmployeeID = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Name: ");
//                employees[i].Name = Console.ReadLine();

//                Console.Write("Salary: ");
//                employees[i].Salary = Convert.ToDouble(Console.ReadLine());
//            }

//            // Display Employee Details
//            Console.WriteLine("\nEmployee Records:");
//            Console.WriteLine("ID\tName\t\tSalary");
//            Console.WriteLine("---------------------------------");

//            double highestSalary = employees[0].Salary;
//            double lowestSalary = employees[0].Salary;
//            Employee highestPaid = employees[0];
//            Employee lowestPaid = employees[0];

//            foreach (var emp in employees)
//            {
//                Console.WriteLine($"{emp.EmployeeID}\t{emp.Name}\t\t{emp.Salary:C}");

//                // Determine highest & lowest salary
//                if (emp.Salary > highestSalary)
//                {
//                    highestSalary = emp.Salary;
//                    highestPaid = emp;
//                }

//                if (emp.Salary < lowestSalary)
//                {
//                    lowestSalary = emp.Salary;
//                    lowestPaid = emp;
//                }
//            }

//            // Display Highest & Lowest Salary Employee
//            Console.WriteLine("\nHighest Paid Employee:");
//            Console.WriteLine($"ID: {highestPaid.EmployeeID}, Name: {highestPaid.Name}, Salary: {highestPaid.Salary:C}");

//            Console.WriteLine("\nLowest Paid Employee:");
//            Console.WriteLine($"ID: {lowestPaid.EmployeeID}, Name: {lowestPaid.Name}, Salary: {lowestPaid.Salary:C}");
//        }
//    }
//}
//Question 2: Sales Data Analysis
//A store keeps track of daily sales for a week. Write a C# program that:
//Declares an array of 7 doubles to store sales data for each day.
//Reads the sales data from the user.
//Calculates and prints the total and average sales.
//Finds and prints the highest and lowest sales with the corresponding day index.
//using System;
//namespace EmployeeRecords
//{
//    class Program
//    {
//        static void Main()
//        {
//            double[] sales = new double[7];
//            double totalSales = 0;
//            double avgSales = 0;
//            int highestSale = 0, lowestSale = 0;


//            for (int i = 0; i < 7; i++)
//            {
//                Console.WriteLine("Enter the sales" + (i + 1) + ":");
//                sales[i] = Convert.ToDouble(Console.ReadLine());
//                totalSales += sales[i];

//            }
//            avgSales = totalSales / 7;
//            for (int i = 1; i < 7; i++)
//            {
//                if (sales[i] > sales[highestSale])
//                {
//                    highestSale = i;

//                }
//                if (sales[i] < sales[lowestSale])
//                {
//                    lowestSale = i;

//                }
//            }
//            Console.WriteLine("Total Sales: " + totalSales);
//            Console.WriteLine("Average Sales: " + avgSales.ToString("F2"));
//            Console.WriteLine("Highest Sales: " + sales[highestSale] + " on Day " + (highestSale + 1));
//            Console.WriteLine("Lowest Sales: " + sales[lowestSale] + " on Day " + (lowestSale + 1));
//        }
//    }
//}
//using System;

//struct Car
//{
//    public int CarID;
//    public string Model;
//    public bool IsAvailable;
//}

//class Program
//{
//    static void Main()
//    {
//        Car[] cars = new Car[3];

//        // Reading car details from user
//        for (int i = 0; i < cars.Length; i++)
//        {
//            Console.WriteLine($"Enter details for car {i + 1}:");
//            Console.Write("Car ID: ");
//            cars[i].CarID = int.Parse(Console.ReadLine());
//            Console.Write("Model: ");
//            cars[i].Model = Console.ReadLine();
//            Console.Write("Is Available (true/false): ");
//            cars[i].IsAvailable = bool.Parse(Console.ReadLine());
//        }

//        // Searching for a car by CarID
//        Console.Write("Enter Car ID to search: ");
//        int searchID = int.Parse(Console.ReadLine());

//        bool found = false;
//        foreach (Car car in cars)
//        {
//            if (car.CarID == searchID)
//            {
//                Console.WriteLine($"Car Model: {car.Model}");
//                Console.WriteLine($"Availability: {(car.IsAvailable ? "Available" : "Not Available")}");
//                found = true;
//                break;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine("Car not found.");
//        }
//    }
//}
using System;
struct Account
{
    public int accountNumber;
    public string name;
    public double balance;
}
class program
{
    static void Main()
    {
        Account[] myaccount = new Account[4];
        for (int i = 0; i < myaccount.Length; i++)
        {


            Console.WriteLine("Enter the account number"+(i+1));
            myaccount[i].accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the account holder name");
            myaccount[i].name = Console.ReadLine();
            Console.WriteLine("Enter the balance");
            myaccount[i].balance = Convert.ToDouble(Console.ReadLine());


        }
        Console.WriteLine("Enter the account number to search");
        int userInput = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        foreach(Account num in myaccount)
        {
            if (num.accountNumber==userInput)
            {
                Console.WriteLine("Name of your account number is" + num.name + "\tbalance is" + num.balance);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Account not found.");
        }

}
}



