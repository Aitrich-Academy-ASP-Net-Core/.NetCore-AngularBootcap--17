using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Transactions;
using System.Xml.Linq;
namespace RentalApplication
{
    class Program
    {
       

        public static void Main(string[] args)
        {
            Property[] property = new Property[10];
            Tenant[] tenant = new Tenant[10];
            Tenant AssignedTenant =new Tenant();
            Property AssignedProperty=new Property();
            Property pty = new Property();
            tenant[0] = new Tenant(1, "Geethu", "8564376921");
            tenant[1] = new Tenant(2, "Priya", "7885432101");
             tenant[2] = new Tenant(3, "Rahul", "9845682312");
             property[0] = new Property(1, "Property1", 2000);
            property[1] = new Property(2, "Property2", 3000);
             property[2] = new Property(3, "Property3", 4000);
            RentalApplicationClass rentalApplicationClass = new RentalApplicationClass(property[0], property[1], property[2], tenant[0], tenant[1], tenant[2]);
            //rentalApplicationClass.AssignTenantToProperty(property[1], tenant[2]);
            
            string ch = "y";
            do
            {
                Console.WriteLine("1.Assign Tenant to Property\n2.Remove Tenant from Property\n3.Display Tenant Details\n4.Display Property Details\n5.Exit");
                string option = Console.ReadLine();
               
                switch (option)
                {
                    case "1":
                        DisplayProperty(property[0], property[1], property[2]);
                        DisplayTenants(tenant[0], tenant[1], tenant[2]);
                        Console.WriteLine("Enter the Address of property ");
                        string Taddr= Console.ReadLine();
                        Console.WriteLine("Enter the name of Tenant ");
                        string Tname= Console.ReadLine();
                        foreach (Property p in property)
                        {
                            if (p!=null && p.Address==Taddr)
                                { AssignedProperty = p;
                                break;
                            }
                        }
                        foreach (Tenant t in tenant)
                        {
                            if (t!=null && t.Name==Tname)
                                { AssignedTenant = t;
                                break;
                            }
                        }

                        if (AssignedProperty != null && AssignedTenant != null)
                            rentalApplicationClass.AssignTenantToProperty(AssignedProperty, AssignedTenant);
                        else
                            Console.WriteLine("Invalid Property or Tenant");
                            break;
                    case "2":
                        Console.WriteLine("Enter Address of the property to be Removed ");
                        Taddr= Console.ReadLine();
                        AssignedProperty = null;
                        foreach(Property p in property)
                        {
                            if(p!=null && p.Address==Taddr)
                            {
                                AssignedProperty = p;
                                break;
                            }
                            }
                        if (AssignedProperty != null)
                       pty.RemoveTenantFromProperty(AssignedProperty);
                        else

                        Console.WriteLine("Invalid Property");
                        break;
                    case "3":
                       
                        DisplayTenants(tenant[0], tenant[1], tenant[2]);

                        break;
                    case "4":
                       
                        DisplayProperty(property[0], property[1], property[2]);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("Doyou want to continue(y/n): ");
                ch=Console.ReadLine();
            } while (ch == "y" || ch == "Y");
        }

        public static void DisplayProperty(Property p1,Property p2,Property p3)
        {
            Console.WriteLine("Property Details");
            Console.WriteLine("----------------");
            Console.WriteLine("PropertyID    Address       Rent    IsOccupied\n");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{p1.PropertyId}           {p1.Address}          {p1.Rent}    {p1.IsOccupied}");
            Console.WriteLine($"{p2.PropertyId}           {p2.Address}          {p2.Rent}    {p2.IsOccupied}");
            Console.WriteLine($"{p3.PropertyId}           {p3.Address}          {p3.Rent}    {p3.IsOccupied}");
        }
        public static void DisplayTenants(Tenant t1,Tenant t2,Tenant t3)
        {
            Console.WriteLine("Tenant Details");
            Console.WriteLine("----------------");
            Console.WriteLine("Tenant ID   Name             Phone Number");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{t1.TenantId}         {t1.Name}           {t1.PhoneNumber}");
            Console.WriteLine($"{t2.TenantId}         {t2.Name}           {t2.PhoneNumber}");
            Console.WriteLine($"{t3.TenantId}         {t3.Name}            {t3.PhoneNumber}");
        }
    }
}