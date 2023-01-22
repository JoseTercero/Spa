namespace Spa.Models
{
    public class BookingStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public ICollection<BookingStatus> Bookings { get;set; }

    }
}
