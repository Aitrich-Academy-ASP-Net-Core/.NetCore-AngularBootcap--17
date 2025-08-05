using BlazorExamm.Model;
namespace BlazorExamm.Services
{
    public class CustomerService
    {
        private readonly List<Customer> _customers = new();
        public List<Customer> GetAll()
        {
            return _customers;
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}
