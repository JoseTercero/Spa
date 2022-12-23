namespace Spa.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastNames { get; set; }

        public string Email { get; set; }

        public ICollection<UserRole> Roles { get; set; }

        public string PassWord { get; set; }
    }
}
