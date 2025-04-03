using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApplication
{
    public class Tenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Tenant(int Id,string name,string phone) {
            TenantId = Id;
            Name = name;
            PhoneNumber = phone;
        }
       
        public Tenant() { }
       
        public void DisplayDetails()
        {
            
            Console.WriteLine($"{TenantId} {Name} {PhoneNumber}");
        }
    }
}
