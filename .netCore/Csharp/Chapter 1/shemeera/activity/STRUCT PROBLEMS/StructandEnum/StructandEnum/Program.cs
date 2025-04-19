internal class Program
{   public enum JobRole
    {
        manager,
        developer,
        tester,
        HR,
    }

    struct Employee
    {
        public int Id;
        public string Name;
        public  JobRole Role;
        public int Salary;
    }
    private static void Main(string[] args)
    {
        Employee[] emp = new Employee[2];

        for (int i = 0; i < 2; i++)
        {

            Console.WriteLine("enter employee id");
            emp[i].Id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the name");
            emp[i].Name = Console.ReadLine();

            Console.WriteLine("enter the jobrole  manager, developer,tester, HR, ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out JobRole role))
            {

                emp[i].Role = role;

            }else
            {
                Console.WriteLine("invalied");
            }


            Console.WriteLine("enter the salary");
            emp[i].Salary = Convert.ToInt32(Console.ReadLine());

        }


        for (int i = 0; i < emp.Length; i++)
        {

            Console.WriteLine("id is : " + emp[i].Id);
            Console.WriteLine("Name is "+emp[i].Name);
            Console.WriteLine("Jobrole is" + emp[i].Role);

            switch (emp[i].Role)
            {
                case JobRole.manager:
                    Console.WriteLine("Handles team and projects.");
                    break;
                case JobRole.developer:
                    Console.WriteLine("Builds software applications.");
                    break;
                case JobRole.tester:
                    Console.WriteLine("Tests applications for bugs.");
                    break;
                case JobRole.HR:
                    Console.WriteLine("Manages employee relations.");
                    break;
                default:
                    Console.WriteLine("Unknown role.");
                    break;
            }


                    Console.WriteLine("salary is " + emp[i].Salary);



        }







    }
}