using System.ComponentModel.Design;
using BlazorApp1.Model;
using BlazorApp1.Repository;
using Microsoft.EntityFrameworkCore;


namespace BlazorApp1.service
{
    public class CustomerService
    {


        //private readonly CustomerRepository _customerRepository;

        //public CustomerService(CustomerRepository customerRepository)
        //{
        //    _customerRepository = customerRepository;
        //}

        //public async Task<List<Customer>> GetCustomersAsync()
        //{
        //    return await _customerRepository.GetCustomersAsync();
        //}

        //public async Task<Customer> GetCustomerByIdAsync(int id)
        //{
        //    return await _customerRepository.GetCustomerByIdAsync(id);
        //}

        //public async Task AddCustomerAsync(Customer customer)
        //{
        //    await _customerRepository.AddCustomerAsync(customer);
        //}


        private readonly CustomerDbContext _context;

        public CustomerService(CustomerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }


        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }




    }

}