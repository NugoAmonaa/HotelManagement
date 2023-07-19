using HotelManagement.Context;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuestController : ControllerBase
    {


        private readonly HotelContext _context;



        public GuestController(HotelContext context)
        {
            _context = context;

        }

        [HttpGet("GetGuests", Name = "GetGuests")]
        public IEnumerable<Guest> GetGuests()

        {
            return _context.Guests.ToList();

        }

        [HttpPost("AddGuest", Name = "AddGuest")]
        public IActionResult Add(Guest guest)
        {
            var guests = _context.Rooms
                           .Where(e => e.Id == guest.Room.Id )
                           .ToList();
            if (guests.Count == 0)
            {
                return BadRequest("Room with given Id does not exist!");
            }
            guest.Room = guests[0];
            _context.Guests.Add(guest);
            _context.SaveChanges();
            return Ok();
        }
       
    }
}