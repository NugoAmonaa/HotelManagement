using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Guest : SuperEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Nationality { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Room Room { get; set; }      

       
        
    }
}
