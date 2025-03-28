using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApplication
{
    public class RentalApplicationClass
    {
        public Property property1 { get; set; }
        public Property property2 { get; set; }
        public Property property3 { get; set; }
        public Tenant tenant1 { get; set; }
        public Tenant tenant2 { get; set; }
        public Tenant tenant3 { get; set; }
        public RentalApplicationClass(Property property1, Property property2, Property property3, Tenant tenant1, Tenant tenant2, Tenant tenant3)
        {
            this.property1 = property1;
            this.property2 = property2;
            this.property3 = property3;
            this.tenant1 = tenant1;
            this.tenant2 = tenant2;
            this.tenant3 = tenant3;
        }
        public void AssignTenantToProperty(Property property, Tenant tenant)
        {
            property.AddTenant(tenant);
            
        }
    }
}
