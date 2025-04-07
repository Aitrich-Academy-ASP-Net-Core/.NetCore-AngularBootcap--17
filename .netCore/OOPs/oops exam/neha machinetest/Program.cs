using neha_machinetest.Libarymember;
using neha_machinetest.Studentmember;
using neha_machinetest.FacultyMember;
using static neha_machinetest.FacultyMember.FacultyMember;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Runtime.Intrinsics.X86;


namespace neha_machinetest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryMember[] members = new LibraryMember[2];
            members[0] = new StudentMember(1, "Neha cj");
            members[1] = new facultyMember(2, "Sageer");
            foreach (LibraryMember member in members)
            {
                int overdueDays = 5;
                member.CalculateFine(overdueDays);
                Console.WriteLine($"Member: {member.Name} (ID: {member.Memberid}), Fine: {member.CalculateFine(overdueDays)}");
            }
        }
    }
}
