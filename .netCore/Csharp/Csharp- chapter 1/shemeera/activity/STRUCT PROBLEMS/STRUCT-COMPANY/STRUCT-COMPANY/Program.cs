internal class Program
{
struct Employee
    {
        public int Id;  
        public string Name;
        public Double Salary;
    }



    private static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];

        Console.WriteLine("enter the number of employee details");
        int count=Convert.ToInt32(Console.ReadLine());


       


        for (int i = 0; i < count; i++)
           

        {
            Console.WriteLine("enter the employee id  {0}",  i+1);
           employees[i]. Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the employee name");
            employees[i].Name = Console.ReadLine();
            Console.WriteLine("enter the salary");
            employees[i].Salary =Convert.ToDouble(Console.ReadLine());




          



        }


        Console.WriteLine("salary details");

        for (int i = 0;i < employees.Length;i++)
        {

            Console.WriteLine("id : {0}" , employees[i].Id);
            Console.WriteLine("NAME : {0}", employees[i].Name);
            Console.WriteLine("SALARY : {0}", employees[i].Salary);
        }

        double highestsalary = employees[0].Salary;
        double lowestsalary = employees[0].Salary;

        foreach (Employee emp in employees)
        {

            if (emp.Salary > highestsalary)
            {
                highestsalary = emp.Salary;
            }
            else if (emp.Salary < lowestsalary)
            {
                lowestsalary = emp.Salary;
            }






        }



        Console.WriteLine("high salary=" + highestsalary);

        Console.WriteLine("lowest salary=" + lowestsalary);


    }
}