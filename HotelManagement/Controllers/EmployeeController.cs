using HotelManagement.Context;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {


        private readonly HotelContext _context;

       

        public EmployeeController(HotelContext context)
        {
            _context = context;
            
        }

        [HttpGet("GetEmployees", Name = "GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
            
        {
            return  _context.Employees.ToList();
            
        }

        [HttpPost("AddEmployee", Name = "AddEmployee")]
        public IActionResult Add(Employee employee)
        {
            var hotels = _context.Hotels
                           .Where(e => e.Id == employee.HotelId)
                           .ToList();
            if (hotels.Count == 0)
            {
                return BadRequest("Hotel with given Id does not exist!");
            }
            employee.Hotel = hotels[0];
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok(); // Return an HTTP 200 OK status code
        }
        [HttpGet("GetEmployeesByHotelId", Name = "GetEmployeesByHotelId")]
        public IActionResult GetEmployeesByHotelId(int hotelId)

        {
            var employees =  _context.Employees
                            .Where(e => e.HotelId == hotelId)
                            .ToList();

      
            return Ok(employees);
        }
    }
}