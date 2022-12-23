using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Spa.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<BookingStatus> Status { get; set; }
        public ICollection<Schedule> Time { get; set; }
        public ICollection<Schedule> Date { get; set; }
        public ICollection<Treatment> Name { get; set; }
        public ICollection<Treatment> Price { get; set; }
        public ICollection<Schedule> Masseuce { get; set; }
    }
}
