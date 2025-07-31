using EmployeeList.Interface;
using EmployeeList.Models;
using EmployeeList.Repository;
namespace EmployeeList.Service
{
    public class EmployeeService:IEmpService
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetEmployeesAsync() =>
            await employeeRepository.GetEmployeesAsync();

        public async Task<Employee> GetEmployeeByIdAsync(int id) =>
            await employeeRepository.GetEmployeeByIdAsync(id);

        public async Task AddEmployeeAsync(Employee employee) =>
            await employeeRepository.AddEmployeeAsync(employee);

        public async Task UpdateEmployeeAsync(Employee employee) =>
            await employeeRepository.UpdateEmployeeAsync(employee);

        public async Task DeleteEmployeeAsync(int id) =>
            await employeeRepository.DeleteEmployeeAsync(id);
    }
}
