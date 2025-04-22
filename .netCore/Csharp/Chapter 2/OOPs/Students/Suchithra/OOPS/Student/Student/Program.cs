using System;
namespace Student
{
    internal class Program
    {
        public static void Main(string[] args) {
            
            Student student = new Student();
            student.Name = "Ajay";
            student.Age = 23;

            Student student2 = new Student();
            //student2.Name = "Aneesh";
            //student2.Age = 27;

            Student student3 = new Student("Sree",26);
            student3.StudentDetails();
            

            student.WriteExam();
            student.StudentDetails();
            student2.StudentDetails();
            
        }
    }
}