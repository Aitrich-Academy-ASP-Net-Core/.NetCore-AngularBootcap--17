using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewShedule
{
    internal class Program
    {
        struct Interview
        {
            public string Title;
            public DateTime Date;
            public string Time;
            public string Location;
        }
        static void Main(string[] args)
        {
            Interview[] shedule = new Interview[10];
        
            Console.WriteLine("------------Shedule An Interview For job Seekers--\n");
           

            string ch;

            do
            {


                Console.WriteLine("A - Schedule a interview \n");
                Console.WriteLine("D - scheduled interview List\n");

                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

                Console.WriteLine("Select an option");
                string Command = Console.ReadLine();
                switch (Command)
                {
                    case "A":
                        {
                            Console.WriteLine("How many no of interviews are sheduling\n");
                            int count = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < count; i++)
                            {

                                Console.WriteLine("----------------------------------------------------------Interview schedule{0}--------------------------------------------------------------------------------------------", i + 1);
                                
                                Console.Write("Enter the Name of job post {0}: ", i + 1);
                                shedule[i].Title = Console.ReadLine();
                                DateTime interviewDate;
                                while (true)
                                {
                                    Console.Write("Enter Interview Date (dd-MM-yyyy): ");
                                    string dateInput = Console.ReadLine();

                                    if (DateTime.TryParseExact(dateInput, "dd-MM-yyyy",
                                        CultureInfo.InvariantCulture, DateTimeStyles.None, out interviewDate))
                                    {
                                        shedule[i].Date = interviewDate;
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Invalid date format. Please enter in dd-MM-yyyy format (e.g., 15-03-2025).");
                                }
                                Console.WriteLine("Enter the Time of a Interview(h-m)");
                                shedule[i].Time = Console.ReadLine();
                                Console.Write("Location of sheduled InterView {0}: ", i + 1);
                                shedule[i].Location = Console.ReadLine();
                                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

                            }
                            break;
                        }
                    case "D":
                        {

                            Console.WriteLine("----------------------------------------------------------Sheduled interview Details are:---------------------------------------------------------------------------");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                            for (int i = 0; i < shedule.Length; i++)
                            {
                                if (shedule[i].Title != null)
                                {
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                                    Console.WriteLine("Name: " + shedule[i].Title);
                                    Console.WriteLine("Date: " + shedule[i].Date.ToString("MM/dd/yyyy"));
                                    Console.WriteLine("Time: " + shedule[i].Time);
                                    Console.WriteLine("Location: " + shedule[i].Location);
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");

                                }
                            }


                            Console.ReadLine();
                            break;
                        }
                }





                Console.WriteLine("Do you want to continue (Y/N)\n");
                ch = Console.ReadLine();

            } while (ch == "y" || ch == "Y");
        }

    }
}


