using InheritanceBank;

internal class Program
{
    private static void Main(string[] args)
    {
       SavingsAccount saving=new SavingsAccount(12457855,3654,5);
        saving.Display();
        saving.Interest();
    }
}