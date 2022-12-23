namespace Spa.Models
{
    
    public class Schedule
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<TreatmentTime> Time { get; set; }
    }
}
