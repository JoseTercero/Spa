namespace Spa.Models
{
    public class TreatmentTime
    {
        public int Id { get; set; }
        public string Time { get; set; }

        public ICollection<Schedule> Schedules { get; set; }

    }
}
