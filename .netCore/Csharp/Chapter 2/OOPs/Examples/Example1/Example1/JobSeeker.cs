
namespace Example1
{
    //[access modifier] - [class] - [identifier]
    //Inheriting User class
    public class JobSeeker: User
    {
        // Fields, properties, methods and events go here...
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        // child class method
        public void ApplyJob(int jobId)
        {
            //function body
            Console.WriteLine("Applying job started");
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to Hire Me Now");
        }
    }
}
