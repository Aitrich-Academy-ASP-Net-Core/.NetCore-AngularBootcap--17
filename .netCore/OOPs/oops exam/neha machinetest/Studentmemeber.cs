using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using neha_machinetest.Libarymember;
using neha_machinetest.FacultyMember;




namespace neha_machinetest.Studentmember
{
    public class StudentMember : LibraryMember 
    {
        public StudentMember(int memberid,string name) : base(memberid, name) { }
        public override double CalculateFine(int overdueDays)
        {
            
            return CalculateStudentFine(overdueDays);
        }

        private double CalculateStudentFine(int overdueDays)
        {
            return overdueDays * 1.0;
        }
    }
}
