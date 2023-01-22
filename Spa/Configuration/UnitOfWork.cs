using Spa.Data;
using Spa.Services;

namespace Spa.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        public ITreatmentRepository TreatmentRepository { get; private set; }

        public ITreatmentTimeRepository TreatmentTimeRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public IUserRoleRepository UserRoleRepository { get; private set; }

        public IScheduleRepository ScheduleRepository { get; private set; }

        public IBookingRepository BookingRepository { get; private set; }

        public IBookingStatusRepository BookingStatusRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            TreatmentRepository = new TreatmentRepository(_context);
            TreatmentTimeRepository = new TreatmentTimeRepository(_context);
            UserRepository = new UserRepository(_context);
            UserRoleRepository = new UserRoleRepository(_context);
            BookingRepository = new BookingRepository(_context);
            BookingStatusRepository = new BookingStatusRepository(_context);
            ScheduleRepository = new ScheduleRepository(_context);


        }
        public void Commit()
        {
            _context.SaveChanges();

        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}
