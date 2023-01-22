using Spa.Data;
using Spa.Models;

namespace Spa.Services
{
    public class BookingStatusRepository: GenericRepository<BookingStatus>, IBookingStatusRepository
    {
        public BookingStatusRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
