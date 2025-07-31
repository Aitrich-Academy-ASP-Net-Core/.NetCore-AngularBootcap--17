using EmployeeList.Models;
using EmployeeList.Service;

namespace EmployeeList.Interface
{
    public interface IEmpService
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task AddEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}
