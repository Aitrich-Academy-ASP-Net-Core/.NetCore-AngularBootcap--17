using JobPortalApplication.Interface;
using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Manager
{
    internal class Printer
    {
        public void print(Job[] jobs) 
        {
            
            foreach (Job job in jobs) 

            {
                if(job!=null)
                Console.WriteLine($"Id,{job.Id},Tittle:{job.Title},company:{job.Company},salary:{job.Salary},Location:{job.Location}");
            
            }
        
        }

        public void print(User[] users)

        {

            foreach (User user in users)
            {
                if (user != null)
                    Console.WriteLine($"Id:{user.Id},Name:{user.FirstName}{user.LastName},Email:{user.Email},Role:{user.Role}");
            }
        
        }

        public void print(Interview[] interview)
        {
           
                foreach (Interview interview1 in interview) 
                {
                if (interview1 != null)
                    Console.WriteLine($"Id:{interview1.Id},Company:{interview1.Company},Location:{interview1.Location},Date:{interview1.Date}");
                
                }

        }
        public void print(Application[] applications)
        {
            
                foreach (Application application in applications) 
                {
                if (applications != null)
                    Console.WriteLine($"Id:{application.Id},Company:{application.Name},Location:{application.Location},Qualification:{application.Qualification}");


                }

        }
    }
}
