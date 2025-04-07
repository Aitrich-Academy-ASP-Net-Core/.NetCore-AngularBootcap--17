using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

internal class Program
{

    public struct Student
    {
       public  int id;
        public string name;
        public int mark;

        public void Display()
        {
            Console.WriteLine($"student details:{id} {name} {mark}");
        }

    }


    private static void Main(string[] args)
    {
     Student student1 ;
        student1.id = 1;
        student1.name = "meera";
        student1.mark = 90;

        Console.WriteLine(student1.id);
        Console.WriteLine(student1 .name);
        Console.WriteLine(student1.mark);

      student1.  Display();


    }
}