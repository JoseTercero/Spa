using Spa.Data;
using Spa.Models;

namespace Spa.Services
{
    public class TreatmentTimeRepository: GenericRepository<TreatmentTime>, ITreatmentTimeRepository
    {
        public TreatmentTimeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
