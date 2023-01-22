using Microsoft.EntityFrameworkCore;
using Spa.Data;
using Spa.Models;

namespace Spa.Services
{
    public class BookingRepository: GenericRepository<Booking>, IBookingRepository
    {
        private readonly ApplicationDbContext _context;
        public BookingRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Booking>> GetAllAsync()
        {
            var applicationDbContext = _context.Booking.Include(b => b.User);
            return await applicationDbContext.ToListAsync();
        }
        public async Task<Booking> GetByIdAsync(int id )
        {
             return await _context.Booking
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
