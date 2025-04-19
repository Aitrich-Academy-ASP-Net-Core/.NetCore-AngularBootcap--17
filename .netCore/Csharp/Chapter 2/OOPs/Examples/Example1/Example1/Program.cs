using Example1;

class Program
{
    static void Main(string[] args)
    {
        // Creating Object of child class
       JobSeeker seeker = new JobSeeker();
        seeker.FirstName = "Richard";
        seeker.LastName = "Wilson";

        //Adding values to properties inherited from 
        seeker.Email = "richard@gmail.com";
        seeker.Password = "123";
        // Calling method in the base class 
        seeker.Login("richard@gmail.com", "123");

        seeker.Welcome();

        //calling fuction in derrived class
        seeker.ApplyJob(1);

    }
}