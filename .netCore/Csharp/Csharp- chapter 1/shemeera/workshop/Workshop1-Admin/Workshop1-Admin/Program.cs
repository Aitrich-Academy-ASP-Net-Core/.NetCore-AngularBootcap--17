internal class Program
{

    struct AdminProfile
    {
        public string Fullname;
        public string Name;
        public string Email;
        public int Phonenumber;












        private static void Main(string[] args)
        {


            AdminProfile[] profile = new AdminProfile[1];


            Console.WriteLine("*********************WELOCOME ADMIN PROFILE************************");
            Console.WriteLine("********************************************************************");

            string ch;

            do
            {
                Console.WriteLine("A . REGISTER");
                Console.WriteLine("B  .DISPLAY ADMIN DETAILS  ");
                Console.WriteLine("SELECT THE OPTION");
                string option= Console.ReadLine();


                switch (option)
                {
                    case "A":

                        {
                            Console.WriteLine("------------------ADMIN REGISTRATION--------------------------");
                            Console.WriteLine("enter the full name");
                            profile[0].Fullname = Console.ReadLine();
                            Console.WriteLine("enter the  name");
                            profile[0].Name = Console.ReadLine();
                            Console.WriteLine("enter the  email");
                            profile[0].Email = Console.ReadLine();
                            Console.WriteLine("enter the  phonenumber");
                            profile[0].Phonenumber = Convert.ToInt32(Console.ReadLine());

                            break;


                        }



                    case "B":


                        {
                            Console.WriteLine("------------------ADMIN DEATAILS--------------------------");
                            Console.WriteLine(" full name" + profile[0].Fullname);

                            Console.WriteLine("  name" + profile[0].Name);

                            Console.WriteLine("  email" + profile[0].Email);

                            Console.WriteLine(" phonenumber" + profile[0].Phonenumber);

                            break;



                        }

                }


                Console.WriteLine("do you want to continue yes/no");
                ch= Console.ReadLine();



                } while (ch=="yes");

        }
    }
}