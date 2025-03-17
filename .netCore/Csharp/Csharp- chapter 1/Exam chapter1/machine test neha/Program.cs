namespace machine_test_neha
{
    internal class Program
    {
        struct Student
        {
            public int Rollnumber;
            public string Name;
            public int[] Grades;
           

        }
        static void Main(string[] args)
        {
            Student[] student = new Student[3];
            int[] grade = new int[5];
            

            for (int i = 0; i < student.Length; i++)
            {
                Console.Write("Enter the Rollnumber : ");
                student[i].Rollnumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the name of student : ");
                student[i].Name = Console.ReadLine();
                student[i].Grades = new int[5];
                Console.WriteLine("Enter the 5 grades : ");
                student[i].Grades[0] = int.Parse(Console.ReadLine());
                student[i].Grades[1] = int.Parse(Console.ReadLine());
                student[i].Grades[2] = int.Parse(Console.ReadLine());
                student[i].Grades[3] = int.Parse(Console.ReadLine());
                student[i].Grades[4] = int.Parse(Console.ReadLine());
 }
            Console.WriteLine("\n Student details and average grade : \n");
            for (int i = 0; i < student.Length; i++)
            {
                int sum = student[i].Grades[0] + student[i].Grades[1] + student[i].Grades[2] + student[i].Grades[3] + student[i].Grades[4];
                double average = (double)sum / 5;
                Console.WriteLine($"Roll Number:{student[i].Rollnumber},Name:{student[i].Name},Average grade : {average}");
            }


        }
    }
}
