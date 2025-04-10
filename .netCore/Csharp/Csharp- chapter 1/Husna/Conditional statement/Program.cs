using System;

namespace Conditional_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark < 40)
            {
                Console.WriteLine("not pass");
            }
            else if(mark<30)
            {
                Console.WriteLine(" fail");
            }
            else if (mark >80)
            {
                Console.WriteLine(" Excellent");
            }
            else
            {
                Console.WriteLine("pass");
            }

            
           /* Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator");
             char operation = Convert.ToChar (Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine(operation);
                    break;


            }
            Console.ReadLine();


            check if a number is positive or negative
            Console.WriteLine("Enter the number");
            int mynum = Convert.ToInt32(Console.ReadLine());
            if (mynum < 0)
            {
                Console.Write("The number is negative");

            }
            else
            {

                Console.Write("The number is positive");

            }
            Console.WriteLine("Enter the number");
            int mynum = Convert.ToInt32(Console.ReadLine());
            if (mynum%2==0)
            {
                Console.Write("The number is even");

            }
            else
            {

                Console.Write("The number is odd");


            }
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("First number is greater than second number");
            }
            else
            {
                Console.WriteLine("Second number is greater than first number");
            }

            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1>num3)
            {
                Console.WriteLine("First number is greater");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("Second number is greater");
            }
            else
            {
                Console.WriteLine("Third number is greater");
            }



            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + "is a leap year");
            }
            else
            {


                Console.WriteLine(year + "is not a leap year");
            }
            Console.WriteLine("Enter the letter");
            string x = (Console.ReadLine() ?? "0");
          
            if (x =="a"|| x == "e" || x =="i" || x =="o" || x == "u")
            {
                Console.WriteLine(x + " is a Vowel.");
            }
            else
            {
                Console.WriteLine(x +" is a Consonant.");
            }






            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                if (num > 0)
                {
                    Console.WriteLine("The number is positive and even");
                }
                else
                {
                    Console.WriteLine("The number is negative and even");
                }
            }
            else
            {
                
                if (num < 0)
                {
                    Console.WriteLine("The number is negative and odd");
                }
                else
                {
                    Console.WriteLine("The number is positive and odd");
                }
            }  

            //checked if eligible for vote
            Console.Write("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("The person is eligible to vote");
            }
            else
            {
                Console.WriteLine("not eligible");
            }  



            Console.WriteLine("Enter the number");
            int mynum = Convert.ToInt32(Console.ReadLine());
            if (mynum < 0)
            {
                Console.Write("The number is negative");

            }
            else if(mynum>0)
            {

                Console.Write("The number is positive");

            }
            else
            {
                Console.Write("The number is zero");
            }


            Switch
               
                Console.WriteLine("Welcome to the Smart Vending Machine");
                Console.WriteLine("Select a product by entering a number (1-5):");
                Console.WriteLine("1 - Coke  - $1.50");
                Console.WriteLine("2 - Chips  - $1.00");
                Console.WriteLine("3 - Chocolate  - $2.00");
                Console.WriteLine("4 - Water  - $1.00");
                Console.WriteLine("5 - Juice  - $1.75");

                Console.Write("Enter product code: ");
                int productCode = Convert.ToInt32(Console.ReadLine());

                switch (productCode)
                {
                    case 1:
                        Console.WriteLine("Coke- $1.50");
                        break;
                    case 2:
                        Console.WriteLine("Chips- $1.00");
                        break;
                    case 3:
                        Console.WriteLine("Chocolate- $2.00");
                        break;
                    case 4:
                        Console.WriteLine("Water- $1.00");
                        break;
                    case 5:
                        Console.WriteLine("Juice- $1.75");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again");
                        break;
                }
            Console.WriteLine("Do you have an access card?");
            
            bool hasaccess = Convert.ToBoolean(Console.ReadLine());
           if (hasaccess)
            {
                Console.WriteLine("Enter your clearance level");
                int clnum = Convert.ToInt32(Console.ReadLine());
                if (clnum >= 5)
                {
                    Console.WriteLine("Allow Entry");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }
            }
            else
            {
                Console.WriteLine("Are you a scientist?");
                bool IsScientist = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Do you know the secret passcode?");
                bool passcode = Convert.ToBoolean(Console.ReadLine());
                if (IsScientist && passcode)
                {
                    Console.WriteLine("Allow Entry");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }
            }
           Console.WriteLine("Do you receive a distress signal? True/False");

           bool hasSignal = Convert.ToBoolean(Console.ReadLine());

            if (hasSignal)
            {
                Console.WriteLine("Initiate rescue operation");
            }
            else
            {
                Console.WriteLine("Is the astronaut in a habitable planet?");
                bool Isinhabitable = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Do you know the secret passcode?");
                bool withindistance = Convert.ToBoolean(Console.ReadLine());
                if (Isinhabitable && withindistance)
                {
                    Console.WriteLine("Initiate rescue operation");
                }
                else
                {
                    Console.WriteLine("Rescue operation Denied");
                }

            }
            Console.WriteLine("Do you solve the puzzle? true/false");
            bool IsSolve = Convert.ToBoolean(Console.ReadLine());
            if (IsSolve)
            {
                Console.WriteLine("Entry allowed");
            }
            else
            {
                Console.WriteLine("Do you possess golden amulet?");
                bool Isgolden = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Do you have a companion who knows the puzzle solution ?");
                bool Iscompanion = Convert.ToBoolean(Console.ReadLine());
                if (Isgolden && Iscompanion)
                {
                    Console.WriteLine("Entry allowed");
                }
                else
                {

                    Console.WriteLine("Are you a direct descendant of the temple's creators?");
                    bool Isdescendant = Convert.ToBoolean(Console.ReadLine());
                    if (Isdescendant)
                    {
                        Console.WriteLine("Entry allowed");
                    }
                    else
                    {

                        Console.WriteLine("Enrty Denied.The door remains locked.");


                    }


                }

            }
            
            Console.WriteLine("Select your present mood:");
            Console.WriteLine("happy");
            Console.WriteLine("sad");
            Console.WriteLine("angry");
            Console.WriteLine("bored");
            Console.WriteLine("excited");
            Console.WriteLine("tired");

            Console.Write("Enter your mood: ");
            string mood = Console.ReadLine() ?? "0";

            Console.WriteLine($"You selected: {mood}");
            switch (mood.ToLower())
            {
                case "happy":
                    Console.WriteLine("Go out and celebrate!");
                    break;
                case "sad":
                    Console.WriteLine("Watch a comforting movie.");
                    break;
                case "angry":
                    Console.WriteLine("Try meditation or deep breathing.");
                    break;
                case "bored":
                    Console.WriteLine("Read a book or try a new hobby.");
                    break;
                case "excited":
                    Console.WriteLine("Share the good news with friends!");
                    break;
                case "tired":
                    Console.WriteLine("Take a nap or rest.");
                    break;
                 default:
                Console.WriteLine("That's an interesting mood! Take care! ");
                break;

            }
            Console.WriteLine("Select any command code");
            Console.WriteLine("launch");
            Console.WriteLine("abort");
            Console.WriteLine("status");
            Console.WriteLine("self destruct");
            Console.WriteLine("reboot");
            string code = Console.ReadLine() ?? "0".ToLower() ;
            switch (code)
            {
                case "launch":
                    Console.WriteLine("Initiating launch sequence");
                    break;
                case "abort":
                    Console.WriteLine("Mission aborted! Returning to standby mode.");
                    break;
                case "status":
                    Console.WriteLine("All systems operational");
                    break;
                case "self destruct":
                    Console.WriteLine("WARNING! Self-destruct sequence initiated!");
                    break;
                case "reboot":
                    Console.WriteLine("Rebooting all systems... Please wait");
                    break;
                default:
                    Console.WriteLine("Invalid command. Please enter a valid operation!");
                    break;


            }*/






        }
        }





    }


