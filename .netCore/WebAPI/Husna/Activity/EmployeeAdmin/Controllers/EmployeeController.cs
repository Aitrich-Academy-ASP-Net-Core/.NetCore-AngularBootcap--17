using EmployeeAdmin.Dto;
using EmployeeAdmin.Model;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeAdmin.Controllers
{
  
        [Route("api/v1/Employee")]
        [ApiController]
        public class EmployeeController : ControllerBase
        {
            private readonly EmployeeDbContext dbContext;
            public EmployeeController(EmployeeDbContext _dbContext)
            {
                dbContext = _dbContext;
            }

            [HttpGet]
            [Route("GetAllEmployees")]
            public IActionResult GetAllEmployees()
            {
                var allEmployees = dbContext.Employees.ToList();
                return Ok(allEmployees);
            }

            [HttpPost]
            public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
            {
                var employeeEntity = new Employee()
                {
                    Name = addEmployeeDto.Name,
                    Email = addEmployeeDto.Email,
                    Phone = addEmployeeDto.Phone,
                    Salary = addEmployeeDto.Salary
                };
                dbContext.Employees.Add(employeeEntity);
                dbContext.SaveChanges();
                //return Ok(employeeEntity);
                return Ok("Addedd Successfully");
            }

            [HttpGet]
            [Route("{id:guid}")]
            public IActionResult GetEmployeeById(Guid id)
            {
                var employee = dbContext.Employees.Find(id);
                if (employee == null)
                {
                    return NotFound();
                }
                return Ok(employee);
            }

            [HttpPut]
            [Route("{id:guid}")]
            public IActionResult UpdateEmployee(Guid id,UpdatedEmployeeDto updatedEmployeeDto)
            {
                var employee = dbContext.Employees.Find(id);
                if (employee == null)
                {
                    return NotFound();
                }
                employee.Name = updatedEmployeeDto.Name;
                employee.Email = updatedEmployeeDto.Email;
                employee.Phone = updatedEmployeeDto.Phone;
                employee.Salary = updatedEmployeeDto.Salary;
                dbContext.SaveChanges();
                return Ok(employee);
            }

            [HttpDelete]
            [Route("{id:guid}")]
            public IActionResult DeleteEmployeeById(Guid id)
            {
                var employee = dbContext.Employees.Find(id);
                if (employee == null)
                {
                    return NotFound();
                }
                dbContext.Employees.Remove(employee);
                dbContext.SaveChanges();
                return Ok(employee);
            }
        }
    
}
