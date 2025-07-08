using SchoolIdb.Modals;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

internal class Program
{
    private static void Main(string[] args)
    {
        var context=new SchoolidbContext();
        var teacher = new Teacher();

        var t1=context.Teachers.ToList();
        foreach(var teachers in t1 )
        {
            Console.WriteLine($"id : {teachers.Id} , Name : {teachers.Name} ,Subject : {teachers.Subject} , year:  {teachers.ExperienceYears}");
        }

        Console.WriteLine("enter the techers datails");
        //Console.WriteLine("enter the techrs id");
        //int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the techrs Name");
        var Name= Console.ReadLine();
        Console.WriteLine("enter the techrs Subject");
        var Subject = Console.ReadLine();

        Console.WriteLine("enter the Experienceyear");
        int year = Convert.ToInt32( Console.ReadLine() );

        //var t=new Teacher { Name=Name , Subject=Subject ,ExperienceYears=year};
        context.Teachers.Add(new Teacher { Name = Name, Subject = Subject, ExperienceYears = year });
        context.SaveChanges();






        //Update 
        Console.WriteLine(" Update Teacher Experience");
        Console.Write("Enter teacher ID to update: ");
        int updateId = Convert.ToInt32(Console.ReadLine());

        var teacherToUpdate = context.Teachers.FirstOrDefault(t => t.Id == updateId);
        if (teacherToUpdate != null)
        {
            Console.Write("Enter new years of experience: ");
            int newExp = Convert.ToInt32(Console.ReadLine());
            teacherToUpdate.ExperienceYears = newExp;
            context.SaveChanges();
            Console.WriteLine(" Teacher updated successfully!");
        }
        else
        {
            Console.WriteLine(" Teacher not found.");
        }






        //Delete a teacher
        Console.WriteLine("\n Delete Teacher");
        Console.Write("Enter teacher ID to delete: ");
        int deleteId = Convert.ToInt32(Console.ReadLine());

        var teacherToDelete = context.Teachers.FirstOrDefault(t => t.Id == deleteId);
        if (teacherToDelete != null)
        {
            context.Teachers.Remove(teacherToDelete);
            context.SaveChanges();
            Console.WriteLine(" Teacher deleted successfully!");
        }
        else
        {
            Console.WriteLine(" Teacher not found.");
        }

        Console.WriteLine("\n Final Teacher List:");

        var techers = context.Teachers.ToList();
        foreach (var t in techers )
        {
            Console.WriteLine($"ID: {t.Id}, Name: {t.Name}, Subject: {t.Subject}, Experience: {t.ExperienceYears} years");
        }
    }
}





    
