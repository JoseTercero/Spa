namespace Spa.Models
{
    
    public class Schedule
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public int UserId { get; set; }
        public int TimeId { get; set; } 
        public User User { get; set; }
        public TreatmentTime TreatmentTime { get; set; }
        
    }
}
