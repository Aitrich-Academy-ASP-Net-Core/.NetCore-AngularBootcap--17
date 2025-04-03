using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Department :Student
    {
       
        public void AddStudent(string dept,int count)
        {
            Student [] stud = new Student[10];
            for (int i=0; i<count;i++)
            {
                stud[i].DeptName = dept;
                Console.WriteLine("Enter Name: ");
                
                stud[i].Name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            stud[i].Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 18 && Age > 25)
            {
                Console.WriteLine("Age is restricted between 18 and 25");
                return;
            }
            Console.WriteLine("Enter Mark1: ");
                stud[i].Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark2: ");
                stud[i].Mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark3: ");
                stud[i].Mark3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark4: ");
                stud[i].Mark4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark5: ");
                stud[i].Mark5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark6: ");
                stud[i].Mark6 = Convert.ToInt32(Console.ReadLine());
                float CGPA =( (Mark1 + Mark2 + Mark3 + Mark4 + Mark5 + Mark6) / 6 )*10;
                stud[i].FindCGPA(stud[i].CGPA);
            }
        }
        public void ListStudents() {
            Student[] stud = new Student[10];
            Console.WriteLine("Name     Age    Dept.Name  Mark1     Mark2     Mark3      Mark4      Mark5     Mark6      CGPA ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine(stud[i].Name+"   " + stud[i].Age+"       " +stud[i].DeptName+"    "+ stud[i].Mark1+"  "+ stud[i].Mark2 + "  "+ stud[i].Mark3 + "  "+ stud[i].Mark4 + "  "+ stud[i].Mark5 + "  "+ stud[i].Mark6 );
            }
        }
        public void FindTopper() {
             Student[] stud = new Student[10];
            int greatest = stud[0].CGPA;
            string topper = "";
            for (int i = 0; i < stud.Length; i++)
            {
                
                if (stud[i].CGPA>greatest)
                {
                    greatest = stud[i].CGPA;
                    topper = stud[i].Name;

                }
                Console.WriteLine("Topper: " + topper);
            }
            
        }
        public void MainMenu()
        {
            string ch;
            do
            {
                Console.WriteLine("1.CSE\n2.ECE\n3.EEE\n4.CE\n5.Exit");
                Console.WriteLine("Select Department");
                string option = Console.ReadLine();
                string dept = "";
                if (option == "1")
                    dept = "CSE";
                else if (option == "2")
                    dept = "ECE";
                else if (option == "3")
                    dept = "EEE";
                else
                    dept = "CE";
                Menu(dept);
                Console.WriteLine("Do you want to continue(y/n): ");
                ch = Console.ReadLine();
            } while (ch == "5");
        }
        public void Menu(string deptName)
        {
           
           
            string ch = "y";
           
            do
            {
                Console.WriteLine("Welcome to " + deptName + " Department");
                Console.WriteLine("Enter the number of students: ");
                int count=Convert.ToInt32(Console.ReadLine());  
                Console.WriteLine("1.Add Student\n2.List Students\n3.Topper\n4.Back To main Menu");
                string option=Console.ReadLine();
                string choice = "y";
                switch (option)
                {
                    case "1":
                           AddStudent(deptName,count);
                        
                        break;
                    case "2":
                        ListStudents();
                        break;
                        case "3":FindTopper();
                        break;
                        case "4":
                        break;

                }

            } while (ch=="y"||ch=="Y");
        }
    }
}

