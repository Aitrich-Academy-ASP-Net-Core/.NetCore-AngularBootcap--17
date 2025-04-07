using Polymorphism_Example;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //creating object of user
        User user = new User();
        User jobseeker = new User();
        jobseeker.Login();
        user.Login();
        user.Login("Yadhu");
        
    }
}