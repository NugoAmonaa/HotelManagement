using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public class Reservation : SuperEntity
    {
        public int Id { get; set; }
        [Required]
        public int GuestId { get; set; }
        [ForeignKey("GuestId")]
        public Guest? Guest { get; set; }
        [Required]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room? Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string ReservationStatus { get; set; }
    }
}