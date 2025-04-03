using Exam2Oops;

internal class Program
{
    private static void Main(string[] args)
    {



        Employee employee=new Employee("Remya", "Developer",40000);
        
        employee.SalaryaValidation();
        Console.WriteLine();

        employee.SalaryIncrease(15);
    }
}