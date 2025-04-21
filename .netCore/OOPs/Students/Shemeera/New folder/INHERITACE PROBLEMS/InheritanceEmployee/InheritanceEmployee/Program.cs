using InheritanceEmployee;

internal class Program
{
    private static void Main(string[] args)
    {
        Manager manager=new Manager("beena", 2000,1000);
        manager.Display();
        manager.TotalSalary();

    }
}