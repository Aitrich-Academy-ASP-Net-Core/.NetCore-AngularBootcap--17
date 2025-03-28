using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class JobSeeker:User
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public void ApplyJob()
        {
            Console.Write("Successfully Applied");

        }
        public override void welcome()
        {
            Console.WriteLine("Welcome user");
        }
    }
}
