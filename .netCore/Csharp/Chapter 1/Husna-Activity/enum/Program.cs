using System;

//enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

//class Program
//{
//    static void Main()
//    {
//        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
//        {
//            Console.WriteLine(day);
//        }
//    }
//}
//enum TrafficLight { Red, Yellow, Green }

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter traffic light color (Red, Yellow, Green): ");
//        string input = Console.ReadLine();

//        if (Enum.TryParse(input, true, out TrafficLight light))
//        {
//            if (light == TrafficLight.Red) {
//            Console.WriteLine("Stop");}
//            else if (light == TrafficLight.Yellow){
//            Console.WriteLine("Get Ready");}
//            else{
//            Console.WriteLine("Go");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input");
//        }
//    }
//}

//enum OrderStatus
//{
//    Pending = 1,
//    Processing = 2,
//    Shipped = 3,
//    Delivered = 4,
//    Cancelled = 5
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter order status number (1-5): ");
//        int input = Convert.ToInt32(Console.ReadLine());
//        if (input >= 1 && input <= 5)
//        {
//            Console.WriteLine("Order Status: " + (OrderStatus)input);
//        }
//        else
//        {
//            Console.WriteLine("Invalid input");
//        }
//    }
//}

//enum SeverityLevel { Low, Medium, High, Critical }

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter severity level (Low, Medium, High, Critical): ");
//        string input = Console.ReadLine();

//        if (Enum.TryParse(input, true, out SeverityLevel level))
//        {
//            switch (level)
//            {
//                case SeverityLevel.Low:
//                    Console.WriteLine("No immediate action needed.");
//                    break;
//                case SeverityLevel.Medium:
//                    Console.WriteLine("Monitor the situation.");
//                    break;
//                case SeverityLevel.High:
//                    Console.WriteLine("Take action soon.");
//                    break;
//                case SeverityLevel.Critical:
//                    Console.WriteLine("Immediate action required!");
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid severity level");
//        }
//    }
//}


//enum Months
//{
//    January = 1, February, March, April, May, June,
//    July, August, September, October, November, December
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter month name (e.g., January): ");
//        string input = Console.ReadLine();

//        if (Enum.TryParse(input, true, out Months month))
//        {
//            Console.WriteLine("The month " + month + " corresponds to " + (int)month + ".");
//        }
//        else
//        {
//            Console.WriteLine("Invalid month name.");
//        }
//    }
//}




//enum WeatherCondition
//{
//    Sunny,
//    Rainy,
//    Cloudy,
//    Windy,
//    Snowy
//}

//class Program
//{
//    static void Main()
//    {
//        WeatherCondition currentWeather = WeatherCondition.Sunny;

//        switch (currentWeather)
//        {
//            case WeatherCondition.Sunny:
//                Console.WriteLine("The weather is " + currentWeather + ":Enjoy the sunshine.");
//                break;
//            case WeatherCondition.Rainy:
//                Console.WriteLine("The weather is " + currentWeather + ": It's raining outside");
//                break;
//            case WeatherCondition.Cloudy:
//                Console.WriteLine("The weather is " + currentWeather + "It might rain.");
//                break;
//            case WeatherCondition.Windy:
//                Console.WriteLine("The weather is " + currentWeather + ": It's quite windy today.");
//                break;
//            case WeatherCondition.Snowy:
//                Console.WriteLine("The weather is " + currentWeather + ": Snow is falling.");
//                break;
//            default:
//                Console.WriteLine("Unknown weather condition: " + currentWeather + ".");
//                break;
//        }
//    }
//}



//enum Department
//{
//    HR = 101,
//    IT = 102,
//    Finance = 103,
//    Marketing = 104
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter department number (101-104): ");
//        if (int.TryParse(Console.ReadLine(), out int deptNumber))
//        {
//            string departmentName = GetDepartmentName(deptNumber);
//            Console.WriteLine(departmentName);
//        }
//        else
//        {
//            Console.WriteLine("Invalid input. Please enter a number.");
//        }
//    }

//    static string GetDepartmentName(int deptNumber)
//    {
//        if (Enum.IsDefined(typeof(Department), deptNumber))
//        {
//            return "Department: " + (Department)deptNumber;
//        }
//        return "Invalid department number.";
//    }
//}

enum PaymentMethod
{
    Cash = 1,
    CreditCard,
    DebitCard,
    UPI,
    NetBanking
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Available Payment Methods:");

        foreach (PaymentMethod method in Enum.GetValues(typeof(PaymentMethod)))
        {
            Console.WriteLine((int)method + ". " + method);
        }

        Console.Write("Select a payment method (enter the number): ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice))
        {
            PaymentMethod selectedMethod = (PaymentMethod)choice;
            Console.WriteLine("You selected: " + selectedMethod);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}

