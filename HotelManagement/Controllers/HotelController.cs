using HotelManagement.Context;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelContoller : ControllerBase
    {


        private readonly HotelContext _context;



        public HotelContoller(HotelContext context)
        {
            _context = context;

        }

        [HttpGet("GetHotels", Name = "GetHotels")]
        public IEnumerable<Hotel> GetHotels()

        {
            return _context.Hotels.ToList();

        }

        [HttpPost("AddHotel", Name = "AddHotel")]
        public IActionResult AddHotel(Hotel hotel)
        {
           
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
            return Ok(); // Return an HTTP 200 OK status code
        }
    }
}