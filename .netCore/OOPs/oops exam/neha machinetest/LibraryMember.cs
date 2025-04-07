using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace neha_machinetest.Libarymember
{
    public abstract class LibraryMember
    {
        public int Memberid { get; set; }
        public string Name { get; set; }
        
           
        public LibraryMember(int memberid,string name)
        {
            Memberid = memberid;
            Name = name;
           
            
        }
        public abstract double CalculateFine(int overdueDays);

    }
   
}
