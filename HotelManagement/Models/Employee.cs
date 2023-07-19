using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace HotelManagement.Models
{
    public class Employee : SuperEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string ContactNumber { get; set; }
        public decimal Salary { get; set; }

        public int HotelId { get; set; }
        public Hotel? Hotel{ get; set; }

        public ICollection<Room>? Rooms { get; set; }


    }
}
