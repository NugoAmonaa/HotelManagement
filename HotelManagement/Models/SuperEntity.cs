namespace HotelManagement.Models
{
    public class SuperEntity
    {
        public DateTime CreateDate { get; set; }

        public SuperEntity()
        {
            CreateDate = DateTime.Now;
        }
    }
}
