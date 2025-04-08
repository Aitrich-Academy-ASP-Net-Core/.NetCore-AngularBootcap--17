namespace Studentscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department student1 = new Department();
            student1.Name = "Sana";
            student1.Age = 23;
            student1.DepartmentName = "CS";
            student1.Mark1 = 8;
            student1.Mark2 = 7;
            student1.Mark3 = 6;
            student1.Mark4 = 9;
            student1.Mark5 = 8;
            student1.Mark6 = 10;
            Department student2 = new Department();
            student2.Name = "Rohan";
            student2.Age = 22;
            student2.DepartmentName = "IT";
            student2.Mark1 = 6;
            student2.Mark2 = 9;
            student2.Mark3 = 9;
            student2.Mark4 = 8;
            student2.Mark5 = 8;
            student2.Mark6 = 10;

            if (student1.CalculateCGPA() > student2.CalculateCGPA())
            {


                Console.WriteLine("Topper:" + student1.Name);
                Console.WriteLine("Department:" + student1.DepartmentName);
                Console.WriteLine("CGPA:" + student1.CalculateCGPA());
                Console.WriteLine("Grade:" + student1.ShowGrade());
            }
            else
            {
                Console.WriteLine("Topper:" + student2.Name);
                Console.WriteLine("Department:" + student2.DepartmentName);
                Console.WriteLine("CGPA:" + student2.CalculateCGPA());
                Console.WriteLine("Grade:" + student2.ShowGrade());

            }

        }
    }
}
