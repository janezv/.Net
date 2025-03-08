using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWindApi.Models;
using NorthWindApi.Data;
using Microsoft.EntityFrameworkCore;
using NorthWindApi.Mappers;
using NorthWindApi.Dtos;

namespace NorthWindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            var Employees = await _context.employees.ToListAsync();
            return Ok(Employees);
        }

        // GET: api/customer
        [HttpGet]
        [Route("/api/sh/Employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployeesSh()
        {
            var EmployeeShort = await _context.employees
                .Select(e => Mappers.EmployeeMapper.EmployeeDto(e))
                .ToListAsync();
            return Ok(EmployeeShort);
        }

        // GET: api/customer/{id}
        [HttpGet("/api/sh/[controller]/{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeSh(int id)
        {
            var employee = await _context.employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            var employeeDto=EmployeeMapper.EmployeeDto(employee);

            return Ok(employeeDto);
        }

        // GET: api/customer/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // POST: api/customer
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getemployee", new { id = employee.EmployeeId }, employee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var customer = await _context.employees.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.employees.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
