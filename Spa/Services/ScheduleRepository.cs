using Microsoft.EntityFrameworkCore;
using Spa.Data;
using Spa.Models;

namespace Spa.Services
{
    public class ScheduleRepository: GenericRepository<Schedule>, IScheduleRepository
    {
        private readonly ApplicationDbContext _context;
        public ScheduleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        public override async Task<IEnumerable<Schedule>> GetAllAsync()
        {
            var applicationDbContext = _context.Schedule.Include(s => s.User);
            return await applicationDbContext.ToListAsync();
        }
        public async Task<Schedule> GetByIdAsync(int id)
        {
            return await _context.Schedule
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
