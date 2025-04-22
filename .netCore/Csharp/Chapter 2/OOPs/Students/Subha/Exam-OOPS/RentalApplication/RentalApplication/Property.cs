using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApplication
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public decimal Rent { get; set; }
        public bool IsOccupied { get; set; }
        public Tenant Tenant { get; set; }
        public Property(int propertyId, string address, decimal rent)
        {
            PropertyId = propertyId;
            Address = address;
            Rent = rent;
            IsOccupied = false;
            Tenant = null;
        }
        public Property() { }
        public void AddTenant(Tenant tenant)
        {
            if (!IsOccupied)
            {
                Tenant = tenant;
                IsOccupied = true;
                Console.WriteLine("The " + Address + " is assigned to " + tenant.Name);
            }
            else
                Console.WriteLine("Property already occupied");

        }
        public void DisplayDetails()
        {
            Console.WriteLine($"{PropertyId}   {Address}      {Rent}       {IsOccupied}");
        }
        public void RemoveTenantFromProperty(Property p)
        {
            if (p.IsOccupied)
            {
                p.IsOccupied = false;
                p.Tenant = null;
                Console.WriteLine("Tenant is removed");
            }
            else
                Console.WriteLine("Property is not occupied");

        }
    }
}