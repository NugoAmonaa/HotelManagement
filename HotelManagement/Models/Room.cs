using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Room : SuperEntity
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public int Occupancy { get; set; }
        public bool IsAvailable { get; set; }
        public decimal Price { get; set; }
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; }
        public int? GuestId { get; set; }
        public Guest? Guest { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}
