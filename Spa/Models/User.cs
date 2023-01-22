namespace Spa.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastNames { get; set; }

        public string Email { get; set; }

        public string PassWord { get; set; }

        public int RoleId { get; set; }
        public UserRole UserRole { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
