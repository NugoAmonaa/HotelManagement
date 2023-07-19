using HotelManagement.Context;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {


        private readonly HotelContext _context;



        public RoomController(HotelContext context)
        {
            _context = context;

        }

        [HttpGet("GetRooms", Name = "GetRooms")]
        public IEnumerable<Room> GetRooms()

        {
            return _context.Rooms.ToList();

        }

        [HttpPost("AddRoom", Name = "AddRoom")]
        public IActionResult Add(Room room)
        {
            Console.WriteLine("safnsfnf");

            var hotels = _context.Hotels
                           .Where(e => e.Id == room.HotelId)
                           .ToList();
            Console.WriteLine("safnsfnf");

            if (hotels.Count == 0)
            {
                return BadRequest("Hotel with given Id does not exist!");
            }
            Console.WriteLine("safnsfnf");

            room.Hotel = hotels[0];
            Console.WriteLine("safnsfnf");
            _context.Rooms.Add(room);
            Console.WriteLine("safnsfnf");

            _context.SaveChanges();
            Console.WriteLine("safnsfnf");

            return Ok();
        }

    }
}