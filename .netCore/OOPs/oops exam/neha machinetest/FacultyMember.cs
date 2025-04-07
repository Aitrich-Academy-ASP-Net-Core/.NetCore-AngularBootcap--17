using neha_machinetest.Libarymember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using neha_machinetest.Libarymember;
using neha_machinetest.Studentmember;


namespace neha_machinetest.FacultyMember
{
    class FacultyMember
    {
        public class facultyMember : LibraryMember
        {
            public facultyMember(int memberid, string name) : base(memberid, name) { }
            public override double CalculateFine(int overdueDays)
            {
                return CalculateFacultyFine(overdueDays);

            }

           
            private double CalculateFacultyFine(int overdueDays)
            {
                return overdueDays * 0.5; 
            }
        }
    }
}
