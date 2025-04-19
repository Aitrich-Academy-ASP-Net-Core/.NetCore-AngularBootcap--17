using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    internal class BorowingRecord
    {
        public string? UserName { get; set; }
        public string? MemberShipId { get; set; }
        public string ?BookTttle { get; set; }
        public DateTime ?BorrowingDate { get; set; }
        public DateTime? ReturnDate { get; set; }


        public BorowingRecord(string username,string id,string title,DateTime borowdate) 
        {
            UserName = username;
            MemberShipId = id;
            BookTttle = title;
            BorrowingDate = borowdate;
        
        }
    }

}
