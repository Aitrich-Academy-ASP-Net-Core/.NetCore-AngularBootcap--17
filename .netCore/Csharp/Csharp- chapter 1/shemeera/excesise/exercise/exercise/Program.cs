using System.Reflection.Metadata.Ecma335;

internal class Program
{


    struct Registration
    {
        public string username;
        public int password;
    }
    struct Jobs
    {
       
        public int Id;
        public string Title;
        public string Experience;
        public string company;
        public string location;
        public int salary;

    }







    private static void Main(string[] args)
    {
        Registration[] registration = new Registration[2];
        Jobs[] jobsListings = new Jobs[3]
        {

            new Jobs { Id = 1, Title = "Software Developer", Experience = "3 years", company = "TechCorp", location = "New York", salary = 75000 },
            new Jobs { Id = 2, Title = "Data Analyst", Experience = "2 years", company = "DataWorks", location = "San Francisco", salary = 65000 },
            new Jobs { Id = 3, Title = "UI/UX Designer", Experience = "4 years", company = "DesignCo", location = "Chicago", salary = 70000 },
        };
        bool login = false;
        string ch;
        Console.WriteLine("**************** WELCOME TO THE JOBSEEKER PORTAL**********");
        Console.WriteLine();
        do
        {
            Console.WriteLine("WELCOME TO THE JOB PORTAL");
            Console.WriteLine("1.  REGISTRASTION");
            Console.WriteLine("2.   LOGIN       ");




            Console.WriteLine("select the option");
            int option = Convert.ToInt32(Console.ReadLine());
            

            switch (option)
            {

                case 1:
                    Console.WriteLine("enter username");
                    registration[0].username = Console.ReadLine();
                    Console.WriteLine("enter password");
                    registration[0].password = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Registration successful");

                    break;




                case 2:


                    Console.WriteLine("enter the username");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("enter password");
                    int pass1 = Convert.ToInt32(Console.ReadLine());

                    
                    if (registration[0].username == name1 && registration[0].password == pass1)
                    {
                        Console.WriteLine("Login successfull");
                        login = true;
                    }

                    break;
            }
        } while (!login);
        bool logout=false;  
        do {

            Console.WriteLine("Welcome" + registration[0].username);

            Console.WriteLine(" 1 .LIST ALL JOS");
            Console.WriteLine(" 2 . MY PROFILE");
            Console.WriteLine(" 3. LOGOUT     ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.WriteLine("list all jobs");
                    foreach (var list in jobsListings)
                    {
                        //Console.WriteLine(list);

                        Console.WriteLine($"Job ID: {list.Id}");
                        Console.WriteLine($"Title: {list.Title}");
                        Console.WriteLine($"Experience: {list.Experience}");
                        Console.WriteLine($"Company: {list.company}");
                        Console.WriteLine($"Location: {list.location}");
                        Console.WriteLine($"Salary: ${list.salary}");
                        Console.WriteLine("----------------------------");

                    }

                    break;
                    



                case 2:
                    Console.WriteLine("view pfofile");
                    Console.WriteLine("Name:" + registration[0].username);
                    break;

                case 3: Console.WriteLine("logout");
                    Console.WriteLine("logged out");
                    logout = true;

                    break;

                default:
                    Console.WriteLine("invalied");
                    break;




            }



            //Console.WriteLine("do you want to continue yes/no");
            //ch = Console.ReadLine();

            //}while(ch == "yes");
        }while (!logout);



    Console.WriteLine("thank you");

    }
}
    