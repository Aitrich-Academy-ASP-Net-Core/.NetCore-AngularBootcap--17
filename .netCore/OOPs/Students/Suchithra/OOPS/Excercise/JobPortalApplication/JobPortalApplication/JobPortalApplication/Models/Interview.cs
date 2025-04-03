using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Models
{
    internal class Interview
    {
        public int Id { get; set; } 
        public string Company { get; set; }
        public string Post {  get; set; }
        public string Date { get; set; }
        public string Location { get; set; }

        public string Time { get; set; }

        public Interview(int id,string company,string post,string date,string location,string time)
        {
            Id = id;
            Company = company;
            Post = post;
            Date = date;
            Location = location;
            Time = time;

        
        }
        public Interview() { }

    }


}
