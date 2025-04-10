namespace Control_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Implement a menu-driven program using a while loop that allows a user to repeatedly choose between different arithmetic operations
            (Addition, Subtraction, Multiplication, Division).
            Console.WriteLine("Choose any arithmetic operation ");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            while (choice == 1)
            {
                Console.WriteLine(num1 + num2);
                break;
            }
            while (choice == 2)
            {
                Console.WriteLine(num1 - num2);
                break;
            }
            while (choice == 3)
            {
                Console.WriteLine(num1 * num2);
                break;
            }
            while (choice == 4)
            {
                Console.
            WriteLine(num1 / num2);


                break;
            }
            PRIME NUMBERS 
            int num = 2;
            
            
            Console.WriteLine("Prime numbers between 1 and 100");
           

            while (num <= 100)
            {
                bool Isprime = true;
                int i = 2;
                while (i <= Math.Sqrt(num))
                {
                    if (num % i == 0)
                    {
                        Isprime = false;
                        break;
                    }

                    i++;
                }

                if (Isprime)
                {
                    Console.Write(num + " ");
                }

                num++;


            }
            string predefinedpssword = "sana123";
            Console.WriteLine("Enter the password");
            string userinput = Console.ReadLine() ?? "0";
            while (predefinedpssword != userinput)
            {
                Console.WriteLine("Incorrect Password");
                Console.WriteLine("Enter the password");
                userinput = Console.ReadLine() ?? "0";
            }

               
                    Console.WriteLine("Access Granted");




            int number;

            do
            {
                Console.Write("Enter a positive number: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 0);

            Console.WriteLine("You entered a valid positive number"+" "+number);





            ATM
               
                decimal balance = 0;
                int choice;

                do
                {
                    Console.WriteLine("\n=== ATM Menu ===");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choose an option: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Enter deposit amount: ");
                        balance += Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"New balance: {balance:C}");
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter withdrawal amount: ");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());

                        if (amount > balance)
                            Console.WriteLine("Insufficient balance.");
                        else
                        {
                            balance -= amount;
                            Console.WriteLine($"New balance: {balance:C}");
                        }
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine($"Current balance: {balance:C}");
                    }
                    else if (choice != 4)
                    {
                        Console.WriteLine("Invalid choice, try again.");
                    }

                } while (choice != 4);

                Console.WriteLine("Thank you for using the ATM!");

            

            Console.WriteLine("Guess a number between 1 and 100:");
            int secretNumber = 22;
            int userGuess;

            do
            {
                Console.Write("Enter your guess: ");
                userGuess=Convert.ToInt32(Console.ReadLine() ?? "0");


            } while (userGuess != secretNumber);

            Console.WriteLine("Congratulations! You guessed the correct number.");
            Console.Write("Enter the number of terms for Fibonacci series: ");
            int n = Convert.ToInt32(Console.ReadLine() ?? "0");
            int num1 = 0, num2 = 1, next;

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(num1 + " ");
                next = num1 + num2;
                num1 = num2;
                num2 = next;
            }


            int fact=1;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = n; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial=" + " " + fact);


            //Pattern
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
            int sum = 0;
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (; num > 0; num /= 10)
            {
                sum += num % 10;
            }

            Console.WriteLine("Sum of digits: " + sum);











        }
}
}
