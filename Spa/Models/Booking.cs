using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Spa.Models
{
    public class Booking
    {
       public int Id { get; set; }
       public string TratmentName { get; set; }
       public double Price { get; set; }
       public string RequestedDate { get; set; }
       public string RequestedTime { get; set; }
       public DateTime CreatedDate { get; set; }
       public DateTime LastUpdatedDate { get; set;}
       public int UserId { get; set; }

       public string UserName { get; set; }
       public string BookingStatus { get; set; }
       public BookingStatus Status { get; set;}
       public  User User { get; set; }
       


    }
}
