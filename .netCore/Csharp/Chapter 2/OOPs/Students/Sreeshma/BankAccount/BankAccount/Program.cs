namespace BankAccount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            CurrentAccount currentAccount = new CurrentAccount();
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("1. Saving Account Balance");
                Console.WriteLine("2. Current Account Balance");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Select any option");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Enter Name");
                    string EnteredName = Console.ReadLine();
                    Console.WriteLine("Enter Id");
                    int EnteredId = Convert.ToInt32(Console.ReadLine());
                    savingAccount.Login(EnteredName, EnteredId);
                }
                else if (option == "2")
                {
                    Console.WriteLine("Enter Name");
                    string EnteredName = Console.ReadLine();
                    Console.WriteLine("Enter Id");
                    int EnteredId = Convert.ToInt32(Console.ReadLine());
                    
                    currentAccount.Login(EnteredName, EnteredId);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Exiting Program");
                    exitProgram= true;
                }
            }
        }
    }
}