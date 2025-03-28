using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Models
{
    internal class Application
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }
        public string Experience{ get; set; }

        public Application(int id,string name,string location,string qualification,string expnce) 
        
        {
            Id = id;
            Name = name;
            Location = location;
            Qualification = qualification;
            Experience = expnce;
            

        
        }
    }
}
