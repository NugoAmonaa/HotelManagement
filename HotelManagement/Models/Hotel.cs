namespace HotelManagement.Models
{
    public class Hotel : SuperEntity
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public  ICollection<Employee>? Employees { get; set; }
        public ICollection<Room>? Rooms { get; set; }



    }
}
